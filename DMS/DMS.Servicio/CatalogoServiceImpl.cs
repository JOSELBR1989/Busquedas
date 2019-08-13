using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos;

namespace DMS.Servicio
{
    public class CatalogoServiceImpl : CatalogoService
    {
        public readonly DMS.DAO.CatalogoDao catalogoDato = new DMS.DAO.CatalogoDaoImpl();

        public void actualizarCatalogo(Catalogos catalogoUpdate)
        {
            catalogoDato.actualizarCatalogo(catalogoUpdate);
        }

        public List<object> busquedaPorDescripcion(string busqueda)
        {
            return catalogoDato.busquedaPorDescripcion(busqueda);
        }

        public List<object> busquedaPorDescripcion(string busqueda, string[] tipoCategoria, bool estado)
        {
            return catalogoDato.busquedaPorDescripcion(busqueda, tipoCategoria, estado);
        }

        public List<object> busquedaPorDescripcion(string busqueda, string[] tipoCategoria)
        {
            return catalogoDato.busquedaPorDescripcion(busqueda, tipoCategoria); 
        }

        public List<object> busquedaPorDescripcionActivos(string busqueda)
        {
            return catalogoDato.busquedaPorDescripcionActivos(busqueda);
        }

        public List<object> busquedaPorDescripcionActivos(string busqueda, string[] tipoCategoria)
        {
            return catalogoDato.busquedaPorDescripcionActivos(busqueda, tipoCategoria);
        }

        public DataTable executeQuery(string Query)
        {
            return catalogoDato.executeQuery(Query);
        }

        public void nuevo(Catalogos catalogo)
        {
            catalogoDato.nuevo(catalogo);
        }

        public Catalogos obtenerCatalogo(long codigoCatalogo)
        {
            return catalogoDato.obtenerCatalogo(codigoCatalogo); 
        }


        public void actualizarScript(ConsultasPorCatalogo consulta)
        {
            catalogoDato.actualizarScript(consulta);
        }

        public void nuevoScript(ConsultasPorCatalogo consulta)
        {
            catalogoDato.nuevoScript(consulta);
        }

        public List<object> listaScripts(long codigoCategoria)
        {
            return catalogoDato.listaScripts(codigoCategoria); 
        }

        public List<object> busquedaPorDescripcionConScripts(string busqueda, string[] tipoCategoria, bool estado)
        {
            return catalogoDato.busquedaPorDescripcionConScripts(busqueda, tipoCategoria, estado);
        }

        public List<object> busquedaPorDescripcionConScripts(string busqueda, string[] tipoCategoria)
        {
            return catalogoDato.busquedaPorDescripcionConScripts(busqueda, tipoCategoria);
        }

        public Catalogos obtenerCatalogo(string schema, string technicalName)
        {
            return this.catalogoDato.obtenerCatalogo(schema, technicalName);
        }
    }
}
