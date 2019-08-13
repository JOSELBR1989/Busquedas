using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Modelos
{
    public class Catalogos: IDefaultDatasource
    {
        private TipoCategoria tipoCategoria;
        private long codigoCatalogo;
        private string nombreCatalogo;
        private string nombreFisico;
        private bool tablaCreada;
        private bool tablaReferenciada;
        private bool activo;
        private bool listoParaCrear;
        private int registrosEnTabla;
        private int cantidadRegistrosEsperados; 
        public Catalogos()
        {
        }

        public Catalogos(TipoCategoria tipoCategoria, long codigoCatalogo, string nombreCatalogo, string nombreFisico, bool tablaCreada, bool tablaReferenciada)
        {
            this.tipoCategoria = tipoCategoria;
            this.codigoCatalogo = codigoCatalogo;
            this.nombreCatalogo = nombreCatalogo;
            this.nombreFisico = nombreFisico;
            this.tablaCreada = tablaCreada;
            this.tablaReferenciada = tablaReferenciada;
        }

        public TipoCategoria TipoCategoria
        {
            get
            {
                return tipoCategoria;
            }

            set
            {
                tipoCategoria = value;
            }
        }

        public long CodigoCatalogo
        {
            get
            {
                return codigoCatalogo;
            }

            set
            {
                codigoCatalogo = value;
            }
        }

        public string NombreCatalogo
        {
            get
            {
                return nombreCatalogo;
            }

            set
            {
                nombreCatalogo = value;
            }
        }

        public string NombreFisico
        {
            get
            {
                return nombreFisico;
            }

            set
            {
                nombreFisico = value;
            }
        }

        public bool TablaCreada
        {
            get
            {
                return tablaCreada;
            }

            set
            {
                tablaCreada = value;
            }
        }

        public bool TablaReferenciada
        {
            get
            {
                return tablaReferenciada;
            }

            set
            {
                tablaReferenciada = value;
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

        public bool ListoParaCrear
        {
            get
            {
                return listoParaCrear;
            }

            set
            {
                listoParaCrear = value;
            }
        }

        public string getDisplayName
        {
            get
            {
                return "NombreCatalogo"; 
            }
        }

        public string getValueMember
        {
            get
            {
                return "CodigoCatalogo"; 
            }
        }

        public int CantidadRegistrosEsperados
        {
            get
            {
                return cantidadRegistrosEsperados;
            }

            set
            {
                cantidadRegistrosEsperados = value;
            }
        }

        public int RegistrosEnTabla
        {
            get
            {
                return registrosEnTabla;
            }

            set
            {
                registrosEnTabla = value;
            }
        }
    }
}
