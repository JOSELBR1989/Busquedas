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
        Modelos.Catalogos obtenerCatalogo(long codigoCatalogo);
        List<Object> busquedaPorDescripcion(string busqueda);
        List<Object> busquedaPorDescripcion(string busqueda, string[] tipoCategoria);
        List<Object> busquedaPorDescripcionActivos(string busqueda);
        List<Object> busquedaPorDescripcionActivos(string busqueda, string[] tipoCategoria);
        void actualizarCatalogo(DMS.Modelos.Catalogos catalogoUpdate);

        void nuevo(DMS.Modelos.Catalogos catalogo);

    }
}
