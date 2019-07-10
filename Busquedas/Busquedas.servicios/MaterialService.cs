using Busquedas.modelo;
using Busquedas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busquedas.servicios
{
    public interface MaterialService
    {
        List<Material> todos(int inicio, int tamanioLote, string Orden);
        List<Material> porNombre(string busqueda, int inicio, int tamanioLote, string Orden);
        List<Material> porFiltrosBusqueda(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda, int inicio, int tamanioLote, string Orden);
        TotalRegistros obtenerTotalRegistros(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda);
        List<Material> materialesEquivalentes(long IdMaterialSistema);

    }
}
