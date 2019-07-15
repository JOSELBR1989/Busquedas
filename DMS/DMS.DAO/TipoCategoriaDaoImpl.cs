using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos;

namespace DMS.DAO
{
    public class TipoCategoriaDaoImpl : TipoCategoriaDao
    {
        DMS.db.DB_DMsEntities db;
        public List<TipoCategoria> tiposCategoria()
        {
            List<TipoCategoria> result = new List<TipoCategoria>(); 
            using (db = new DMS.db.DB_DMsEntities())
            {
                result = (from da in db.CAT_Categoria
                          select new TipoCategoria
                          {
                              Codigo = da.IdCategoria,
                              Nombre = da.Nombre,
                              EsquemaFisico = da.Esquema
                          }).ToList();
            }

            return result; 
        }
    }
}
