using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos;
using DMS.DAO;

namespace DMS.Servicio
{
    public class ColumnasTablaServiceImpl : ColumnasTablaService
    {
        private readonly ColumnasTablaDao columnasTablaDao = new ColumnasTablaDaoImpl();

        public void actualizar(CamposCatalogo campo)
        {
            columnasTablaDao.actualizar(campo);
        }

        public void actualizarGrupo(CamposCatalogo campo)
        {
            columnasTablaDao.actualizarGrupo(campo);
        }

        public void actualizarPK(CamposCatalogo campo)
        {
            columnasTablaDao.actualizarPK(campo);
        }

        public List<object> busquedaGeneral(string busqueda)
        {
            return columnasTablaDao.busquedaGeneral(busqueda); 
        }

        public List<Object> columnasTabla(Catalogos catalogoPadre)
        {
            return columnasTablaDao.columnasTabla(catalogoPadre); 
        }

        public List<Object> columnasTablaPK(Catalogos catalogoPadre)
        {
            return columnasTablaDao.columnasTablaPK(catalogoPadre);
        }

        public List<Object> columnasYTablas(string busqueda, CamposCatalogo campos)
        {
            return columnasTablaDao.columnasYTablas(busqueda, campos);
        }

        public void crearAsociacionCampos(CamposCatalogo campoFK, CamposCatalogo campoPK)
        {
            columnasTablaDao.crearAsociacionCampos(campoFK, campoPK); 
        }

        public void desactivarCampo(long codigoCampoCatalogo, bool activo)
        {
            columnasTablaDao.desactivarCampo(codigoCampoCatalogo, activo);
        }

        public void eliminarCampo(long codigoCampoCatalogo)
        {
            columnasTablaDao.eliminarCampo(codigoCampoCatalogo);
        }

        public List<object> erroresAsociaciones(int catalogo)
        {
            return columnasTablaDao.erroresAsociaciones(catalogo);
        }

        public void nuevo(CamposCatalogo campo)
        {
            columnasTablaDao.nuevo(campo);
        }

        public CamposCatalogo obtenePorId(CamposCatalogo campoBusqueda)
        {
            return columnasTablaDao.obtenePorId(campoBusqueda); 
        }

        public List<Object> obtenerAsociacionesColumna(CamposCatalogo campo)
        {
            return columnasTablaDao.obtenerAsociacionesColumna(campo); 
        }

        public void quitarAsociacionCampos(long CatalogoCampoId, long CatalogoCampoIdRef)
        {
            columnasTablaDao.quitarAsociacionCampos(CatalogoCampoId, CatalogoCampoIdRef);
        }
    }
}
