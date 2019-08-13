using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Servicio
{
    public interface CatalogoRelacionesServicie
    {
        void agregarRelacion(long IdCatalogoPK, long IdCatalogoFK);
        void agregarRelacionColumna(long IdRelacionCatalogo, long CatalogoCampoIdPK, long? CatalogoCampoIdFK);

        List<Object> obtenerTablasRelacionadas(long IdCatalogoFK);
        List<Object> obtenerColumnasTablasRelacionadas(long IdCatalogoFK, long vIdRelacionCatalogo);
        List<Object> columnasParaAsignarComoFK(long IdRelacionCatalogo);
    }
}
