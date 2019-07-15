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
                    dato.Descripcion = campo.DescripcionCampo;
                    try
                    {
                        dato.IdAgrupacion = (int?)campo.Agrupacion.IdAgrupacion;
                    }
                    catch
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
            catch
            {
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

        public List<object> columnasTabla(Catalogos catalogoPadre)
        {
            List<Object> resultado = new List<object>();

            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.CatalogoCampos
                             where da.IdCatalogo == catalogoPadre.CodigoCatalogo
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
                             }).ToList().Cast<Object>().ToList(); 
            }

            return resultado;
        }

        public List<object> columnasTablaPK(Catalogos catalogoPadre)
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

        public List<object> columnasYTablas(string busqueda, CamposCatalogo campos)
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
                DMS.db.CamposCatalogoReferencias cat = new DMS.db.CamposCatalogoReferencias();
                cat.CatalogoCampoId = campoFK.CodigoCampoCatalogo;
                cat.CatalogoCampoIdRef = campoPK.CodigoCampoCatalogo;
                cat.Activo = true;
                cat.UpdateRule = "";
                db.CamposCatalogoReferencias.Add(cat);
                db.SaveChanges(); 
            }
        }

        public DataTable executeQuery(string Query)
        {
            var dt = new DataTable();
            Query = "INSERT INTO scConfiguration.CamposCatalogoReferencias(CatalogoCampoId,CatalogoCampoIdRef,UpdateRule,Activo)";
            using (db = new DMS.db.DB_DMsEntities())
            {
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = Query;
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
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

            return dt;
        }

        public void nuevo(CamposCatalogo campo)
        {
            using (db = new DMS.db.DB_DMsEntities())
            {
                db.CatalogoCampos catalogo = new DMS.db.CatalogoCampos();
                catalogo.IdCatalogo = (int)campo.Catalogo.CodigoCatalogo;
                try{
                    catalogo.IdAgrupacion = (int?)campo.Agrupacion.IdAgrupacion;

                }
                catch
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

        public CamposCatalogo obtenePorId(CamposCatalogo campoBusqueda)
        {
            CamposCatalogo result = new CamposCatalogo();
            using (db = new DMS.db.DB_DMsEntities())
            {
                result = (from da in db.CatalogoCampos
                          where da.CatalogoCampoId == campoBusqueda.CodigoCampoCatalogo
                          select new CamposCatalogo
                          {
                              NombreCampo = da.NombreCampo,
                              DescripcionCampo = da.Descripcion,
                              NombreTecnicoCampo = da.NombreTecnico,
                              TipoDatoCampo = da.TipoDato,
                              Tamanio = da.Tamanio,
                              Presicion = da.Precision,
                              ConReferencia = da.CampoConReferencia,
                              Requerido = da.Requerido,
                              LlavePrimaria = false,
                              Orden = 0,
                              Activo = true
                          }).ToList().FirstOrDefault();
            }
            return result; 
        }

        public List<object> obtenerAsociacionesColumna(CamposCatalogo campo)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.CamposCatalogoReferencias
                             where da.CatalogoCampoId == campo.CodigoCampoCatalogo &&
                             da.Activo == true
                             select new
                             {
                                 CodigoCatalogoBase = da.CatalogoCampos.CatalogoCampoId,
                                 NombreCampoCatalogoBase = da.CatalogoCampos.NombreCampo + " [" + da.CatalogoCampos.NombreTecnico + "]",
                                 NombreTablaReferencia = da.CatalogoCampos.Catalogos.NombreCatalogo + " [" + da.CatalogoCampos.Catalogos.NombreFisico + "]",
                                 CodigoCataloReferencia = da.CatalogoCampoIdRef,
                                 NombreCataloReferencia = da.CatalogoCamposFK.NombreCampo + " [" + da.CatalogoCamposFK.NombreTecnico  + "]"
                             }).ToList().Cast<Object>().ToList();
            }
            return resultado; 
        }
    }
}
