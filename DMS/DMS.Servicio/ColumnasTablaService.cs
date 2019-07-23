using DMS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Servicio
{
    public interface ColumnasTablaService
    {
        List<Object> columnasTabla(Catalogos catalogoPadre);
        List<Object> columnasTablaPK(Catalogos catalogoPadre);
        List<Object> columnasYTablas(string busqueda, CamposCatalogo campos);
        List<Object> obtenerAsociacionesColumna(DMS.Modelos.CamposCatalogo campo);
        List<Object> erroresAsociaciones(int catalogo);

        void nuevo(DMS.Modelos.CamposCatalogo campo);
        void actualizar(DMS.Modelos.CamposCatalogo campo);
        void actualizarPK(DMS.Modelos.CamposCatalogo campo);
        void actualizarGrupo(DMS.Modelos.CamposCatalogo campo);

        void crearAsociacionCampos(DMS.Modelos.CamposCatalogo campoFK, DMS.Modelos.CamposCatalogo campoPK);
        void quitarAsociacionCampos(long CatalogoCampoId, long CatalogoCampoIdRef);
        CamposCatalogo obtenePorId(DMS.Modelos.CamposCatalogo campoBusqueda);

        #region "Eliminar desactivar registros"
        void desactivarCampo(long codigoCampoCatalogo, bool activo);
        void eliminarCampo(long codigoCampoCatalogo);

        #endregion
    }
}
