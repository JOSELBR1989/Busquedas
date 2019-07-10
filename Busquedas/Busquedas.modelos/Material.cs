using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busquedas.modelo
{
    public class Material
    {
        private long idMaterial;
        private int idSistemaCatalogo;
        private string nombreSistema;
        private string nombreCatalogo;
        private string codigoMaterialSistemaBase;
        private string nombre;
        private bool? manejaLote;
        private int? diasVencimiento;
        private bool activo;
        private bool migrarSap;
        private string descripcionAmpliada;
        private string codigoVisible;
        private int companyBuildId;
        private long idMaterialSistema;
        private long correlativo;
        private string codigoTipoMaterial;
        private string tipoMaterialDescripcion;


        public Material()
        {

        }
        public long IdMaterial
        {
            get
            {
                return idMaterial;
            }

            set
            {
                idMaterial = value;
            }
        }
        public string CodigoTipoMaterial
        {
            get
            {
                return codigoTipoMaterial;
            }

            set
            {
                codigoTipoMaterial = value;
            }
        }
        public string TipoMaterialDescripcion
        {
            get
            {
                return tipoMaterialDescripcion;
            }

            set
            {
                tipoMaterialDescripcion = value;
            }
        }

        [DisplayName("Codigo")]
        public string CodigoVisible
        {
            get
            {
                return codigoVisible;
            }

            set
            {
                codigoVisible = value;
            }
        }
        public int IdSistemaCatalogo
        {
            get
            {
                return idSistemaCatalogo;
            }

            set
            {
                idSistemaCatalogo = value;
            }
        }
        public string NombreSistema
        {
            get
            {
                return nombreSistema;
            }

            set
            {
                nombreSistema = value;
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
        public string CodigoMaterialSistemaBase
        {
            get
            {
                return codigoMaterialSistemaBase;
            }

            set
            {
                codigoMaterialSistemaBase = value;
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
        public bool? ManejaLote
        {
            get
            {
                return manejaLote;
            }

            set
            {
                manejaLote = value;
            }
        }
        public int? DiasVencimiento
        {
            get
            {
                return diasVencimiento;
            }

            set
            {
                diasVencimiento = value;
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
        public bool MigrarSap
        {
            get
            {
                return migrarSap;
            }

            set
            {
                migrarSap = value;
            }
        }
        public string DescripcionAmpliada
        {
            get
            {
                return descripcionAmpliada;
            }

            set
            {
                descripcionAmpliada = value;
            }
        }
        public int CompanyBuildId
        {
            get
            {
                return companyBuildId;
            }

            set
            {
                companyBuildId = value;
            }
        }
        public long IdMaterialSistema
        {
            get
            {
                return idMaterialSistema;
            }

            set
            {
                idMaterialSistema = value;
            }
        }
        public long Correlativo
        {
            get
            {
                return correlativo;
            }

            set
            {
                correlativo = value;
            }
        }
    }
}
