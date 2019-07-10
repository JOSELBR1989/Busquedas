using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Modelos
{
    public class CamposCatalogo
    {
        private long codigoCampoCatalogo;
        private Catalogos catalogo;
        private string nombreCampo;
        private string descripcionCampo;
        private string nombreTecnicoCampo;
        private string tipoDatoCampo;
        private int tamanio;
        private int? presicion;
        private bool conReferencia;
        private bool requerido;
        private bool llavePrimaria;
        private int orden;

        public CamposCatalogo()
        {

        }
        public CamposCatalogo(long codigoCampoCatalogo, Catalogos catalogo, string nombreCampo, string descripcionCampo, string nombreTecnicoCampo, string tipoDatoCampo, int tamanio, int presicion, bool conReferencia, bool requerido, bool llavePrimaria, int orden)
        {
            this.codigoCampoCatalogo = codigoCampoCatalogo;
            this.catalogo = catalogo;
            this.nombreCampo = nombreCampo;
            this.descripcionCampo = descripcionCampo;
            this.nombreTecnicoCampo = nombreTecnicoCampo;
            this.tipoDatoCampo = tipoDatoCampo;
            this.tamanio = tamanio;
            this.presicion = presicion;
            this.conReferencia = conReferencia;
            this.requerido = requerido;
            this.llavePrimaria = llavePrimaria;
            this.orden = orden;
        }

        public long CodigoCampoCatalogo
        {
            get
            {
                return codigoCampoCatalogo;
            }

            set
            {
                codigoCampoCatalogo = value;
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

        public string NombreCampo
        {
            get
            {
                return nombreCampo;
            }

            set
            {
                nombreCampo = value;
            }
        }

        public string DescripcionCampo
        {
            get
            {
                return descripcionCampo;
            }

            set
            {
                descripcionCampo = value;
            }
        }

        public string NombreTecnicoCampo
        {
            get
            {
                return nombreTecnicoCampo;
            }

            set
            {
                nombreTecnicoCampo = value;
            }
        }

        public string TipoDatoCampo
        {
            get
            {
                return tipoDatoCampo;
            }

            set
            {
                tipoDatoCampo = value;
            }
        }

        public int Tamanio
        {
            get
            {
                return tamanio;
            }

            set
            {
                tamanio = value;
            }
        }

        public int? Presicion
        {
            get
            {
                return presicion;
            }

            set
            {
                presicion = value;
            }
        }

        public bool ConReferencia
        {
            get
            {
                return conReferencia;
            }

            set
            {
                conReferencia = value;
            }
        }

        public bool Requerido
        {
            get
            {
                return requerido;
            }

            set
            {
                requerido = value;
            }
        }

        public bool LlavePrimaria
        {
            get
            {
                return llavePrimaria;
            }

            set
            {
                llavePrimaria = value;
            }
        }

        public int Orden
        {
            get
            {
                return orden;
            }

            set
            {
                orden = value;
            }
        }

    }
}
