using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAO
{
    public class CatalogoRelacionesDaoImpl : CatalogoRelacionesDao
    {
        DMS.db.DB_DMsEntities db;

        public void agregarRelacion(long IdCatalogoPK, long IdCatalogoFK)
        {
            using (db = new DMS.db.DB_DMsEntities())
            {
                db.RelacionCatalogos_INS(IdCatalogoPK, IdCatalogoFK, true);
            }
        }

        public void agregarRelacionColumna(long IdRelacionCatalogo, long CatalogoCampoIdPK, long? CatalogoCampoIdFK)
        {
            using (db = new DMS.db.DB_DMsEntities())
            {

                var datos = (from da in db.RelacionCatalogoCampos
                             where da.IdRelacionCatalogo == IdRelacionCatalogo &&
                             da.CatalogoCampoIdPK == CatalogoCampoIdPK
                             select da).FirstOrDefault();


                datos.CatalogoCampoIdFK = CatalogoCampoIdFK;
                db.SaveChanges();  
            }
        }

        public List<object> columnasParaAsignarComoFK(long IdRelacionCatalogo)
        {
            List<Object> result = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                result = (from da in db.CatalogoCamposParaAsignarFK(IdRelacionCatalogo)
                          select da).ToList().Cast<Object>().ToList(); 
            }

            return result; 
        }

        public List<object> obtenerColumnasTablasRelacionadas(long IdCatalogoFK, long vIdRelacionCatalogo)
        {
            List<Object> resultado = new List<object>();
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.RelacionCatalogoCampos_Get(IdCatalogoFK)
                             where da.IdRelacionCatalogo == vIdRelacionCatalogo
                             select new
                             {
                                 da.CatalogoCampoId,
                                 da.ValorMostrarCampo,
                                 da.CatalogoCampoIdFK,
                                 da.TipoDato,
                                 da.Precision,
                                 da.Tamanio,
                                 da.IdRelacionCatalogo
                             }
                             ).ToList().Distinct().Cast<Object>().ToList();
            }

            return resultado;
        }

        public List<object> obtenerTablasRelacionadas(long IdCatalogoFK)
        {
            List<Object> resultado = new List<object>(); 
            using (db = new DMS.db.DB_DMsEntities())
            {
                resultado = (from da in db.RelacionCatalogoCampos_Get(IdCatalogoFK)
                             select new {
                                 da.IdRelacionCatalogo,
                                 da.ValorMostrarCatalogo
                             }
                             ).ToList().Distinct().Cast<Object>().ToList(); 
            }

            return resultado; 
        }

    }
}
