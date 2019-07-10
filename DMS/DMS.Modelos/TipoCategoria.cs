using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Modelos
{
    public class TipoCategoria
    {
        private int codigo;
        private string nombre;
        private string esquemaFisico;

        public TipoCategoria()
        {

        }
        public TipoCategoria(int codigo, string nombre, string esquemaFisico)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.esquemaFisico = esquemaFisico;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string EsquemaFisico
        {
            get
            {
                return esquemaFisico;
            }

            set
            {
                esquemaFisico = value;
            }
        }



    }
}
