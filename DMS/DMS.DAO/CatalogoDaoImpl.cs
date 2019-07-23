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
                    dato.NombreCatalogo = catalogoUpdate.NombreCatalogo;
                    dato.TablaCreada = catalogoUpdate.TablaCreada;
                    dato.Activa = catalogoUpdate.Activo;
                    dato.ListoParaCrear = catalogoUpdate.ListoParaCrear;

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
                             }).ToList().Cast<Object>().ToList();
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

                    db.Catalogos.Add(cat);
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                throw;
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
                             }).ToList().Cast<Object>().ToList();
            }
            return resultado;
        }
    }
}
