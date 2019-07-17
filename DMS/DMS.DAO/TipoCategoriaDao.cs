using DMS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAO
{
    public interface TipoCategoriaDao
    {
        List<DMS.Modelos.TipoCategoria> tiposCategoria();
        TipoCategoria tiposCategoriaId( int id);

    }
}
