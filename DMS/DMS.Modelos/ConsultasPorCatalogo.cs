using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Modelos
{
    public class ConsultasPorCatalogo: IDefaultDatasource
    {
        private Catalogos catalogo; 
        private int idCatalogoConsulta;
        private string nombre;
        private string descripcion;
        private string scriptExecute;
        private bool activo;

        public Catalogos Catalogo
        {
            get
            {
                return catalogo;
            }

            set
            {
                catalogo = value;
            }
        }

        public int IdCatalogoConsulta
        {
            get
            {
                return idCatalogoConsulta;
            }

            set
            {
                idCatalogoConsulta = value;
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

        public string ScriptExecute
        {
            get
            {
                return scriptExecute;
            }

            set
            {
                scriptExecute = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        public string getDisplayName
        {
            get
            {
                return "Nombre";
            }
        }

        public string getValueMember
        {
            get
            {
                return "IdCatalogoConsulta"; 
            }
        }
    }
}
