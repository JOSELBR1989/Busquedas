using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Modelos
{
    public class Agrupaciones : IDefaultDatasource
    {
        private long idAgrupacion;
        private Catalogos catalogo;
        private string nombreGrupo;
        private string descripcion;

        public Agrupaciones()
        {
        }

        public string getDisplayName
        {
            get
            {
                return "NombreGrupo"; 
            }
        }

        public string getValueMember
        {
            get
            {
                return "IdAgrupacion"; 
            }
        }

        public long IdAgrupacion
        {
            get
            {
                return idAgrupacion;
            }

            set
            {
                idAgrupacion = value;
            }
        }

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

        public string NombreGrupo
        {
            get
            {
                return nombreGrupo;
            }

            set
            {
                nombreGrupo = value;
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
