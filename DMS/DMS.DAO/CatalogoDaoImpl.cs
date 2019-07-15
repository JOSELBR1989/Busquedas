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
                    db.SaveChanges(); 
                }
            }
            catch
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
                                 Activo = (da.Activa == true) ? "SI" : "NO"
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
                                 Activo = (da.Activa == true) ? "SI" : "NO"
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
                    cat.NombreFisico = catalogo.NombreFisico;
                    cat.TablaCreada = catalogo.TablaCreada;
                    cat.Referenciada = catalogo.TablaReferenciada;
                    cat.Activa = catalogo.Activo;

                    db.Catalogos.Add(cat);
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                throw;
            }
        }
    }
}
