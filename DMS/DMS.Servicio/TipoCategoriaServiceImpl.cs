using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos;

namespace DMS.Servicio
{
    public class TipoCategoriaServiceImpl : TipoCategoriaService
    {
        private readonly DMS.DAO.TipoCategoriaDao tipoCategoria = new DMS.DAO.TipoCategoriaDaoImpl(); 
        public List<TipoCategoria> tiposCategoria()
        {
            return tipoCategoria.tiposCategoria(); 
        }

        public TipoCategoria tiposCategoriaId(int id)
        {
            return tipoCategoria.tiposCategoriaId(id);
        }
    }
}
