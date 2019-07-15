using DMS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Servicio
{
    public interface CatalogoService: ExecuteQuery
    {
        List<Object> busquedaPorDescripcion(string busqueda);
        List<Object> busquedaPorDescripcionActivos(string busqueda);
        void actualizarCatalogo(DMS.Modelos.Catalogos catalogoUpdate);

        void nuevo(DMS.Modelos.Catalogos catalogo);

    }
}
