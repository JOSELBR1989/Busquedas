using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos;

namespace DMS.DAO
{
    public class ColumnasTablaDaoImpl : ColumnasTablaDao
    {
        private db.DB_DMsEntities db;

        public void actualizar(CamposCatalogo campo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.CatalogoCampos
                                where da.CatalogoCampoId == campo.CodigoCampoCatalogo
                                select da).FirstOrDefault();
                    dato.NombreCampo = campo.NombreCampo;
                    if(!dato.Catalogos.TablaCreada)
                        dato.NombreTecnico = campo.NombreTecnicoCampo; 
                    dato.Descripcion = campo.DescripcionCampo;
                    try
                    {
                        dato.IdAgrupacion = (int?)campo.Agrupacion.IdAgrupacion;
                    }
                    catch(Exception ex)
                    {
                    }
                    dato.TipoDato = campo.TipoDatoCampo;
                    dato.Tamanio = campo.Tamanio;
                    dato.Precision = campo.Presicion;
                    dato.Requerido = campo.Requerido;
                    dato.LlavePrimaria = campo.LlavePrimaria;
                    dato.Orden = campo.Orden; 

                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void actualizarGrupo(CamposCatalogo campo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.CatalogoCampos
                                where da.CatalogoCampoId == campo.CodigoCampoCatalogo
                                select da).FirstOrDefault();
                    dato.IdAgrupacion = (int?)campo.Agrupacion.IdAgrupacion;
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void actualizarPK(CamposCatalogo campo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.CatalogoCampos
                                where da.CatalogoCampoId == campo.CodigoCampoCatalogo
                                select da).FirstOrDefault();
                    dato.LlavePrimaria = campo.LlavePrimaria;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> busquedaGeneral(string busqueda)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.VW_Campos
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda) ||
                             da.NombreCompletoCatalogo.Contains(busqueda) ||
                             da.NombreTecnico.Contains(busqueda) ||
                             da.DescriptionCampo.Contains(busqueda)) && da.Activa == true && da.Activo == true
                             select da).ToList().OrderBy(x=> x.Esquema) .Cast<Object>().ToList();
            }

            return resultado; 
        }

        public List<Object> columnasTabla(Catalogos catalogoPadre)
        {
            List<Object> resultado = new List<object>();

            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.CatalogoCampos
                             where da.IdCatalogo == catalogoPadre.CodigoCatalogo &&
                             da.Activo == true
                             select new
                             {
                                 da.CatalogoCampoId,
                                 da.IdAgrupacion,
                                 da.Agrupaciones.NombreAgrupacion,
                                 da.NombreTecnico,
                                 da.NombreCampo,
                                 da.Descripcion,
                                 da.TipoDato,
                                 da.Tamanio,
                                 da.Precision,
                                 CampoConReferencia = (da.CampoConReferencia == true) ? "S" : "",
                                 Requerido = (da.Requerido == true) ? "S" : "N",
                                 LlavePrimaria = (da.LlavePrimaria == true) ? "SI" : "",
                                 da.Orden,
                                 da.Activo,
                                 NameWithTechnicalCode = da.NombreCampo + " (" + da.NombreTecnico + ")"
                             }).ToList().OrderBy(x=> x.Orden).Cast<Object>().ToList(); 
            }

            return resultado;
        }
        public List<Object> columnasTablaPK(Catalogos catalogoPadre)
        {
            List<Object> resultado = new List<object>();

            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.CatalogoCampos
                             where da.IdCatalogo == catalogoPadre.CodigoCatalogo
                             && da.LlavePrimaria == true && da.Activo == true
                             select new
                             {
                                 da.CatalogoCampoId,
                                 NameWithTechnicalCode = da.NombreCampo + " (" + da.NombreTecnico + ")"
                             }).ToList().Cast<Object>().ToList();
            }

            return resultado;

        }
        public List<Object> columnasYTablas(string busqueda, CamposCatalogo campos)
        {
            List<Object> resultado = new List<object>();

            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.CatalogoCampos
                             where (da.Catalogos.NombreCatalogo.Contains(busqueda) ||
                                    da.Catalogos.NombreFisico.Contains(busqueda) ||
                                    da.NombreCampo.Contains(busqueda) ||
                                    da.NombreTecnico.Contains(busqueda) ||
                                    da.Catalogos.CAT_Categoria.Nombre.Contains(busqueda) ||
                                    da.Catalogos.CAT_Categoria.Esquema.Contains(busqueda)) &&
                                    da.LlavePrimaria == true
                             select new
                             {
                                 da.Catalogos.CAT_Categoria.Esquema,

                             }).ToList().Cast<Object>().ToList();
            }

            return resultado;
        }
        public void crearAsociacionCampos(CamposCatalogo campoFK, CamposCatalogo campoPK)
        {
            using (db = new DMS.db.DB_DMsEntities())
            {
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                StringBuilder strb = new StringBuilder();
                strb.AppendLine("INSERT INTO scConfiguration.CamposCatalogoReferencias(CatalogoCampoId,CatalogoCampoIdRef,Activo)");
                strb.AppendLine("VALUES(");
                strb.AppendLine(campoFK.CodigoCampoCatalogo.ToString() + ",");
                strb.AppendLine(campoPK.CodigoCampoCatalogo.ToString() + ",");
                strb.AppendLine("1");
                strb.AppendLine(")");
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = strb.ToString();
                        cmd.CommandType = CommandType.Text;
                        var reader = cmd.ExecuteReader();
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }

            }
        }
        public void desactivarCampo(long codigoCampoCatalogo, bool activo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.CatalogoCampos
                                where da.CatalogoCampoId == codigoCampoCatalogo
                                select da).FirstOrDefault();
                    dato.Activo = activo;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminarCampo(long codigoCampoCatalogo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var conn = db.Database.Connection;
                    var connectionState = conn.State;
                    StringBuilder strb = new StringBuilder();
                    strb.AppendLine("DELETE FROM CC");
                    strb.AppendLine("FROM	scConfiguration.CamposCatalogoReferencias AS CC");
                    strb.AppendLine("WHERE CatalogoCampoId = " + codigoCampoCatalogo.ToString() + ";");
                    strb.AppendLine("DELETE FROM CC");
                    strb.AppendLine("FROM	scConfiguration.CamposCatalogoReferencias AS CC");
                    strb.AppendLine("WHERE CatalogoCampoIdRef = " + codigoCampoCatalogo.ToString() + ";");
                    try
                    {
                        if (connectionState != ConnectionState.Open) conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = strb.ToString();
                            cmd.CommandType = CommandType.Text;
                            var reader = cmd.ExecuteReader();
                        }
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                    finally
                    {
                        if (connectionState != ConnectionState.Closed) conn.Close();
                    }
                }

                using (db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.CatalogoCampos
                                where da.CatalogoCampoId == codigoCampoCatalogo
                                select da).FirstOrDefault();
                    db.CatalogoCampos.Remove(dato);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Object> erroresAsociaciones(int catalogo)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.CamposCatalogoReferenciasPorCatalogo(catalogo)
                             select da).ToList().Cast<Object>().ToList();
            }
            return resultado; 
        }
        public void nuevo(CamposCatalogo campo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    db.CatalogoCampos catalogo = new DMS.db.CatalogoCampos();
                    catalogo.IdCatalogo = (int)campo.Catalogo.CodigoCatalogo;
                    try
                    {
                        catalogo.IdAgrupacion = (int?)campo.Agrupacion.IdAgrupacion;

                    }
                    catch (Exception ex)
                    {
                    }
                    catalogo.NombreCampo = campo.NombreCampo;
                    catalogo.Descripcion = campo.DescripcionCampo;
                    catalogo.NombreTecnico = campo.NombreTecnicoCampo;
                    catalogo.TipoDato = campo.TipoDatoCampo;
                    catalogo.Tamanio = campo.Tamanio;
                    catalogo.Precision = campo.Presicion;
                    catalogo.CampoConReferencia = campo.ConReferencia;
                    catalogo.Requerido = campo.Requerido;
                    catalogo.LlavePrimaria = campo.LlavePrimaria;
                    catalogo.Activo = campo.Activo;

                    db.CatalogoCampos.Add(catalogo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public CamposCatalogo obtenePorId(CamposCatalogo campoBusqueda)
        {
            CamposCatalogo result = new CamposCatalogo();
            using (db = new DMS.db.DB_DMsEntities())
            {
                result = (from da in db.CatalogoCampos
                          where da.CatalogoCampoId == campoBusqueda.CodigoCampoCatalogo
                          select new CamposCatalogo
                          {
                              CodigoCampoCatalogo = da.CatalogoCampoId,
                              NombreCampo = da.NombreCampo,
                              DescripcionCampo = da.Descripcion,
                              NombreTecnicoCampo = da.NombreTecnico,
                              TipoDatoCampo = da.TipoDato,
                              Tamanio = da.Tamanio,
                              Presicion = da.Precision,
                              ConReferencia = da.CampoConReferencia,
                              Requerido = da.Requerido,
                              LlavePrimaria = da.LlavePrimaria,
                              Orden = da.Orden,
                              Activo = da.Activo
                          }).ToList().FirstOrDefault();
            }
            return result; 
        }
        public List<Object> obtenerAsociacionesColumna(CamposCatalogo campo)
        {
            List<Object> resultado = new List<object>();
            //using (db = new DMS.db.DB_DMsEntities())
            //{
            //    resultado = (from da in db.CamposCatalogoReferencias
            //                 where da.CatalogoCampoId == campo.CodigoCampoCatalogo &&
            //                 da.Activo == true
            //                 select new
            //                 {
            //                     CodigoCatalogoBase = da.CatalogoCampos.CatalogoCampoId,
            //                     NombreCampoCatalogoBase = da.CatalogoCampos.NombreCampo + " [" + da.CatalogoCampos.NombreTecnico + "]",
            //                     NombreTablaReferencia = da.CatalogoCamposFK.Catalogos.NombreCatalogo + " [" + da.CatalogoCamposFK.Catalogos.NombreFisico + "]",
            //                     CodigoCataloReferencia = da.CatalogoCampoIdRef,
            //                     NombreCataloReferencia = da.CatalogoCamposFK.NombreCampo + " [" + da.CatalogoCamposFK.NombreTecnico  + "]"
            //                 }).ToList().Cast<Object>().ToList();
            //}
            return resultado; 
        }
        public void quitarAsociacionCampos(long CatalogoCampoId, long CatalogoCampoIdRef)
        {
            using (db = new DMS.db.DB_DMsEntities())
            {
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                StringBuilder strb = new StringBuilder();
                strb.AppendLine("UPDATE ccr SET ccr.Activo	 = 0 FROM	scConfiguration.CamposCatalogoReferencias ccr ");
                strb.AppendLine("WHERE ccr.CatalogoCampoId = " + CatalogoCampoId.ToString());
                strb.AppendLine("AND ccr.CatalogoCampoIdRef =  " + CatalogoCampoIdRef.ToString());

                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = strb.ToString();
                        cmd.CommandType = CommandType.Text;
                        var reader = cmd.ExecuteReader();
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }


            }
        }


        }
}
