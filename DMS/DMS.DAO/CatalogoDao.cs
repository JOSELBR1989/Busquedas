using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAO
{
    public interface CatalogoDao: ExecuteQuery
    {
        List<Object> busquedaPorDescripcion(string busqueda);
        List<Object> busquedaPorDescripcionActivos(string busqueda);
        void actualizarCatalogo(DMS.Modelos.Catalogos catalogoUpdate);

        void nuevo(DMS.Modelos.Catalogos catalogo);

    }
}
