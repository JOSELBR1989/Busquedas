using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS.Modelos;

namespace DMS.InterfazUsuario.CreacionEstructura
{
    public partial class Relaciones : UserControl
    {
        private Modelos.Catalogos catalogoPadre;
        private Modelos.Catalogos catalogoForanea;

        public Catalogos CatalogoPadre
        {
            get
            {
                return catalogoPadre;
            }

            set
            {
                catalogoPadre = value;
            }
        }

        public Catalogos CatalogoForanea
        {
            get
            {
                return catalogoForanea;
            }

            set
            {
                catalogoForanea = value;
            }
        }

        public Relaciones()
        {
            InitializeComponent();
        }


    }
}
