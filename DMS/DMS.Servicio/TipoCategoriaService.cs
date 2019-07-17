using DMS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Servicio
{
    public interface TipoCategoriaService
    {
        List<TipoCategoria> tiposCategoria();
        TipoCategoria tiposCategoriaId(int id);
    }
}
