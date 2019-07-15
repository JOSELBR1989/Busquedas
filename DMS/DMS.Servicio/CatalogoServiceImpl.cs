﻿using System;
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

        public List<object> busquedaPorDescripcionActivos(string busqueda)
        {
            return catalogoDato.busquedaPorDescripcionActivos(busqueda);
        }

        public DataTable executeQuery(string Query)
        {
            return catalogoDato.executeQuery(Query);
        }

        public void nuevo(Catalogos catalogo)
        {
            catalogoDato.nuevo(catalogo);
        }
    }
}
