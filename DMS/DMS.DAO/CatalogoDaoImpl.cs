using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos;
using System.Data.Entity.Validation;

namespace DMS.DAO
{
    public class CatalogoDaoImpl : CatalogoDao
    {
        private db.DB_DMsEntities db;

        public DMS.Modelos.Catalogos obtenerCatalogo(long codigoCatalogo)
        {
            Catalogos catalogos = new Catalogos();

            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.Catalogos
                                where da.IdCatalogo == codigoCatalogo
                                select da).ToList().FirstOrDefault();

                    catalogos.CodigoCatalogo = dato.IdCatalogo;
                    catalogos.NombreCatalogo = dato.NombreCatalogo;
                    catalogos.NombreFisico = dato.NombreFisico;
                    catalogos.TablaCreada = dato.TablaCreada;
                    catalogos.TablaReferenciada = dato.Referenciada;
                    catalogos.Activo = dato.Activa;
                    catalogos.ListoParaCrear = dato.ListoParaCrear;
                    catalogos.TipoCategoria = new TipoCategoria(dato.CAT_Categoria.IdCategoria, dato.CAT_Categoria.Nombre,dato.CAT_Categoria.Esquema);
                    catalogos.ListoParaCrear = dato.ListoParaCrear;
                    catalogos.CantidadRegistrosEsperados = (int)dato.CantidadRegistros; 

                }
            }
            catch(Exception ex)
            {
            }

            return catalogos; 
        }

        public void actualizarCatalogo(Catalogos catalogoUpdate)
        {
            try
            {
                using(db = new DMS.db.DB_DMsEntities())
                {
                    var dato = (from da in db.Catalogos
                                where da.IdCatalogo == catalogoUpdate.CodigoCatalogo
                                select da).FirstOrDefault();
                    dato.IdCategoria = catalogoUpdate.TipoCategoria.Codigo; 
                    dato.NombreFisico = catalogoUpdate.NombreFisico; 
                    dato.NombreCatalogo = catalogoUpdate.NombreCatalogo;
                    dato.TablaCreada = catalogoUpdate.TablaCreada;
                    dato.Activa = catalogoUpdate.Activo;
                    dato.ListoParaCrear = false;
                    dato.CantidadRegistros = catalogoUpdate.CantidadRegistrosEsperados; 
                    db.SaveChanges(); 
                }
            }
            catch(Exception ex)
            {
            }
        }

        public List<object> busquedaPorDescripcion(string busqueda)
        {
            List<Object> resultado = new List<object>(); 
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                              where da.NombreCatalogo.Contains(busqueda) ||
                              da.NombreFisico.Contains(busqueda)
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().Cast<Object>().ToList();
            }
            return resultado;
        }

        public List<object> busquedaPorDescripcion(string busqueda, string[] tipoCategoria)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda)) &&
                             tipoCategoria.Contains(da.CAT_Categoria.Esquema)
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().OrderBy(x => x.NombreCategoria).Cast<Object>().ToList();
            }
            return resultado;

        }

        public List<object> busquedaPorDescripcionActivos(string busqueda)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda)) && da.Activa == true
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().Cast<Object>().ToList();
            }
            return resultado;
        }

        public List<object> busquedaPorDescripcionActivos(string busqueda, string[]  esquemas)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda)) && da.Activa == true
                             && esquemas.Contains(da.CAT_Categoria.Esquema)
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().Cast<Object>().ToList();
            }
            return resultado;
        }

        public DataTable executeQuery(string Query)
        {
            var dt = new DataTable();
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

        public void nuevo(Catalogos catalogo)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    DMS.db.Catalogos cat = new DMS.db.Catalogos();

                    cat.IdCategoria = catalogo.TipoCategoria.Codigo;
                    cat.NombreCatalogo = catalogo.NombreCatalogo;
                    cat.NombreFisico = catalogo.NombreFisico.Replace(" ","");
                    cat.TablaCreada = catalogo.TablaCreada;
                    cat.Referenciada = catalogo.TablaReferenciada;
                    cat.Activa = catalogo.Activo;
                    cat.ListoParaCrear = catalogo.ListoParaCrear;
                    cat.IdCategoria = catalogo.TipoCategoria.Codigo;
                    cat.ListoParaCrear = false;
                    cat.CantidadRegistros = catalogo.CantidadRegistrosEsperados; 

                    db.Catalogos.Add(cat);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> busquedaPorDescripcion(string busqueda, string[] tipoCategoria, bool estado)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda)) &&
                             tipoCategoria.Contains(da.CAT_Categoria.Esquema) && da.Activa == estado
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().OrderBy(x => x.NombreCategoria).Cast<Object>().ToList();
            }
            return resultado;
        }

        public List<object> listaScripts(long codigoCategoria)
        {
            List<Object> result = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                result = (from da in db.CatalogoConsultas
                          where da.Activo == true
                          where da.Catalogos.IdCatalogo == codigoCategoria
                          select da).ToList().Cast<Object>().ToList();
            }
            return result; 
        }

        public void actualizarScript(ConsultasPorCatalogo consulta)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    var item = (from da in db.CatalogoConsultas
                                where da.IdCatalogoConsulta == consulta.IdCatalogoConsulta
                                select da).ToList().FirstOrDefault();
                    item.Nombre = consulta.Nombre;
                    item.Descripcion = consulta.Descripcion;
                    item.Activo = consulta.Activo;
                    item.ScriptExecute = consulta.ScriptExecute;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void nuevoScript(ConsultasPorCatalogo consulta)
        {
            try
            {
                using (db = new DMS.db.DB_DMsEntities())
                {
                    db.CatalogoConsultas dato = new DMS.db.CatalogoConsultas(); 


                    dato.IdCatalogo = (int)consulta.Catalogo.CodigoCatalogo;  
                    dato.Nombre = consulta.Nombre;
                    dato.Descripcion = consulta.Descripcion;
                    dato.ScriptExecute = consulta.ScriptExecute;
                    dato.Activo = consulta.Activo;
                    db.CatalogoConsultas.Add(dato);
                    db.SaveChanges(); 
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public List<object> busquedaPorDescripcionConScripts(string busqueda, string[] tipoCategoria, bool estado)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                             join catalogo in db.CatalogoConsultas on da.IdCatalogo equals catalogo.IdCatalogo
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda)) &&
                             tipoCategoria.Contains(da.CAT_Categoria.Esquema) && da.Activa == estado &&
                             catalogo.Activo == true
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().OrderBy(x => x.NombreCategoria).Cast<Object>().Distinct().ToList();
            }
            return resultado;
        }

        public List<object> busquedaPorDescripcionConScripts(string busqueda, string[] tipoCategoria)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.Catalogos
                             join catalogo in db.CatalogoConsultas on da.IdCatalogo equals catalogo.IdCatalogo
                             where (da.NombreCatalogo.Contains(busqueda) ||
                             da.NombreFisico.Contains(busqueda)) &&
                             tipoCategoria.Contains(da.CAT_Categoria.Esquema) &&
                             catalogo.Activo == true
                             select new
                             {
                                 IdCategoria = da.CAT_Categoria.IdCategoria,
                                 NombreCategoria = da.CAT_Categoria.Nombre,
                                 IdCatalogo = da.IdCatalogo,
                                 NombreCatalogo = da.NombreCatalogo,
                                 NombreFisicoCatalogo = da.NombreFisico,
                                 TablaCreada = (da.TablaCreada == true) ? "SI" : "NO",
                                 Referenciada = (da.Referenciada == true) ? "SI" : "NO",
                                 Activo = (da.Activa == true) ? "SI" : "NO",
                                 ListoParaCrear = da.ListoParaCrear
                             }).ToList().OrderBy(x => x.NombreCategoria).Cast<Object>().Distinct().ToList();
            }
            return resultado;
        }

        public Catalogos obtenerCatalogo(string schema, string technicalName)
        {
            Catalogos catalogo = new Catalogos();
            using (db = new DMS.db.DB_DMsEntities())
            {
                try
                {
                    catalogo = (from da in db.Catalogos
                                where da.CAT_Categoria.Esquema == schema
                                && da.NombreFisico == technicalName
                                select new Modelos.Catalogos {
                                    CodigoCatalogo = da.IdCatalogo,
                                    NombreCatalogo = da.NombreCatalogo,
                                    NombreFisico = da.NombreFisico

                                }).FirstOrDefault();

                }
                catch (Exception)
                {
                    catalogo = new Catalogos(); 
                }
            }

            return catalogo; 
        }
    }
}
