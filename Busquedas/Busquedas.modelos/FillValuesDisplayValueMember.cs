using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busquedas.modelos
{
    public class FillValuesDisplayValueMember
    {
        string codigo;
        string nombre;

        public FillValuesDisplayValueMember(string codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public string Codigo
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
    }
}
