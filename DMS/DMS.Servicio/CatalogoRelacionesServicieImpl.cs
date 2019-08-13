using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Servicio
{
    public class CatalogoRelacionesServicieImpl : CatalogoRelacionesServicie
    {
        private readonly DMS.DAO.CatalogoRelacionesDao catalogoRelacionesDao = new DMS.DAO.CatalogoRelacionesDaoImpl();

        public void agregarRelacion(long IdCatalogoPK, long IdCatalogoFK)
        {
            this.catalogoRelacionesDao.agregarRelacion(IdCatalogoPK, IdCatalogoFK);
        }

        public void agregarRelacionColumna(long IdRelacionCatalogo, long CatalogoCampoIdPK, long? CatalogoCampoIdFK)
        {
            this.catalogoRelacionesDao.agregarRelacionColumna(IdRelacionCatalogo, CatalogoCampoIdPK, CatalogoCampoIdFK);
        }

        public List<object> columnasParaAsignarComoFK(long IdRelacionCatalogo)
        {
            return catalogoRelacionesDao.columnasParaAsignarComoFK(IdRelacionCatalogo);
        }

        public List<object> obtenerColumnasTablasRelacionadas(long IdCatalogoFK, long vIdRelacionCatalogo)
        {
            return this.catalogoRelacionesDao.obtenerColumnasTablasRelacionadas(IdCatalogoFK,vIdRelacionCatalogo);
        }

        public List<object> obtenerTablasRelacionadas(long IdCatalogoFK)
        {
            return this.catalogoRelacionesDao.obtenerTablasRelacionadas(IdCatalogoFK);
        }
    }
}
