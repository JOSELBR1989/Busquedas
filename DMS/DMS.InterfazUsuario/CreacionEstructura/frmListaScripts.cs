using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.InterfazUsuario.CreacionEstructura
{
    public partial class frmListaScripts : Form
    {
        Modelos.ConsultasPorCatalogo consulta;
        Modelos.Catalogos catalogo;
        bool crearNuevo = false; 
        public frmListaScripts(DMS.Modelos.Catalogos catalogoBase)
        {
            InitializeComponent();
            consulta = new Modelos.ConsultasPorCatalogo();
            catalogo = new Modelos.Catalogos();
            this.catalogo = catalogoBase; 
            crearNuevo = true; 
            btnGuardar.Click += BtnGuardar_Click;
        }
        public frmListaScripts(DMS.Modelos.Catalogos catalogoBase, DMS.Modelos.ConsultasPorCatalogo consultaBase)
        {
            InitializeComponent();
            consulta = new Modelos.ConsultasPorCatalogo();
            catalogo = new Modelos.Catalogos();
            crearNuevo = false; 
            this.catalogo = catalogoBase; 
            this.consulta = consultaBase;
            btnGuardar.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && richDescription.Text.Length > 0)
            {
                consulta.Catalogo = catalogo; 
                consulta.Nombre = txtNombre.Text;
                consulta.Descripcion = richDescription.Text;
                consulta.ScriptExecute = String.Empty;
                consulta.Activo = true;

                try
                {
                    if (crearNuevo)
                        (new DMS.Servicio.CatalogoServiceImpl()).nuevoScript(consulta);
                    else
                        (new DMS.Servicio.CatalogoServiceImpl()).actualizarScript(consulta);

                    this.Close();
                }
                catch (Exception ex)
                {
                    DMS.UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                }

            }
            else {
                DMS.UtilidadesDesktop.MessageBoxUtilities.camposIncompletos("Nombre y descripcion");
            }
        }



    }
}
