using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busquedas.modelos
{
    public class TotalRegistros
    {
        private long totalRegistro;
        private string descripcion;

        public TotalRegistros()
        {

        }

        public TotalRegistros(long totalRegistro, string descripcion)
        {
            this.totalRegistro = totalRegistro;
            this.descripcion = descripcion;
        }

        public long TotalRegistro
        {
            get
            {
                return totalRegistro;
            }

            set
            {
                totalRegistro = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}
