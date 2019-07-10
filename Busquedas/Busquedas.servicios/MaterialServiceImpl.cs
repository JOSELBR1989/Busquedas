using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busquedas.modelo;
using Busquedas.modelos;

namespace Busquedas.servicios
{
    public class MaterialServiceImpl : MaterialService
    {
        private readonly DAO.MaterialDao materialDao = new DAO.MaterialDaoImpl();

        public List<Material> materialesEquivalentes(long IdMaterialSistema)
        {
            return materialDao.materialesEquivalentes(IdMaterialSistema);
        }

        public TotalRegistros obtenerTotalRegistros(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda)
        {
            return materialDao.obtenerTotalRegistros(manejaLotes, activos, paraMigrarSap, Busqueda);
        }

        public List<Material> porFiltrosBusqueda(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda, int inicio, int tamanioLote, string Orden)
        {
            return materialDao.porFiltrosBusqueda(manejaLotes, activos, paraMigrarSap, Busqueda, inicio, tamanioLote, Orden);
        }

        public List<Material> porNombre(string busqueda, int inicio, int tamanioLote, string Orden)
        {
            return materialDao.porNombre(busqueda, inicio, tamanioLote, Orden);
        }

        public List<Material> todos(int inicio, int tamanioLote, string Orden)
        {
            return materialDao.todos(inicio, tamanioLote, Orden); 
        }
    }
}
