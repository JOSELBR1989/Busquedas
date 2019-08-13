using DMS.Modelos;
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
    public partial class NuevoCatalogo : Form
    {

        public DMS.Modelos.Catalogos catalogoActualizar { get; set; }

        public NuevoCatalogo()
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardar_Click;
            DMS.UtilidadesDesktop.ComboboxUtilities.fillCombobox(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref cmbTipoCatalogo);

        }

        public NuevoCatalogo(DMS.Modelos.Catalogos catalogo)
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardar_Click;
            catalogoActualizar = catalogo;

            txtCodigoCatalogo.Text = catalogo.CodigoCatalogo.ToString();
            txtNombreCatalogo.Text = catalogo.NombreCatalogo;
            txtNombreFisicoCatalogo.Text = catalogo.NombreFisico;
            numericUpDown1.Value = catalogo.CantidadRegistrosEsperados;
            chkActivo.Checked = catalogo.Activo;
            chkPendienteCrear.Checked = catalogo.TablaCreada;
            DMS.UtilidadesDesktop.ComboboxUtilities.fillCombobox(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref cmbTipoCatalogo);

            cmbTipoCatalogo.Enabled = !chkPendienteCrear.Checked;
            numericUpDown2.Value = catalogoActualizar.RegistrosEnTabla; 
            bool encontrado = false; 
            for (int i = 0; i < cmbTipoCatalogo.Items.Count; i++)
            {
                if (catalogo.TipoCategoria.Codigo == ((TipoCategoria)cmbTipoCatalogo.Items[i]).Codigo)
                {
                    cmbTipoCatalogo.SelectedIndex = i;
                    encontrado = true;
                    break; 
                }
            }

            if (!encontrado)
            {
                cmbTipoCatalogo.SelectedItem = null; 
            }




        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            int codigoCatalogo = 0; 
            try
            {
                codigoCatalogo = Convert.ToInt16(txtCodigoCatalogo.Text); 
            }
            catch (Exception ex)
            {
                codigoCatalogo = 0; 
            }
            if (codigoCatalogo > 0)
                ActualizarRegistro();
            else
                NuevoRegistro();
        }

        public void NuevoRegistro()
        {
            if (txtNombreCatalogo.Text.Replace(" ", "").Length > 0 &&
                txtNombreFisicoCatalogo.Text.Replace(" ", "").Length > 0 &&
                cmbTipoCatalogo.SelectedItem != null)
            {
                catalogoActualizar = new Catalogos();
                catalogoActualizar.TipoCategoria = (TipoCategoria)cmbTipoCatalogo.SelectedItem;
                catalogoActualizar.NombreFisico = txtNombreFisicoCatalogo.Text.Replace(" ", "");
                catalogoActualizar.NombreCatalogo = txtNombreCatalogo.Text;
                catalogoActualizar.CantidadRegistrosEsperados = (int)numericUpDown1.Value;
                catalogoActualizar.TablaCreada = chkPendienteCrear.Checked;
                catalogoActualizar.Activo = chkActivo.Checked;
                try
                {
                    (new Servicio.CatalogoServiceImpl()).nuevo(catalogoActualizar);

                    var result = (new Servicio.CatalogoServiceImpl()).obtenerCatalogo(catalogoActualizar.TipoCategoria.EsquemaFisico, catalogoActualizar.NombreFisico);
                    catalogoActualizar = new Catalogos();
                    this.catalogoActualizar = result;
                    this.Close(); 

                }
                catch (Exception ex)
                {
                    UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                }

        }
            else {
                MessageBox.Show("No se puede procesar los datos, favor revisar el nombre, nombre físico y tipo de catálogo","Error con datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void ActualizarRegistro() {
            if (txtNombreCatalogo.Text.Replace(" ", "").Length > 0 &&
                txtNombreFisicoCatalogo.Text.Replace(" ", "").Length > 0 &&
                cmbTipoCatalogo.SelectedItem != null)
            {

                if (!chkPendienteCrear.Checked)
                {
                    catalogoActualizar.TipoCategoria = (TipoCategoria)cmbTipoCatalogo.SelectedItem;
                    catalogoActualizar.NombreFisico = txtNombreFisicoCatalogo.Text.Replace(" ",""); 
                }
                catalogoActualizar.NombreCatalogo = txtNombreCatalogo.Text;
                catalogoActualizar.CantidadRegistrosEsperados = (int)numericUpDown1.Value;
                catalogoActualizar.TablaCreada = chkPendienteCrear.Checked;
                catalogoActualizar.Activo = chkActivo.Checked;

                try
                {
                    (new Servicio.CatalogoServiceImpl()).actualizarCatalogo(catalogoActualizar);
                    this.Close();
                }
                catch (Exception ex)
                {
                    UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                }

            }
            else
            {
                MessageBox.Show("No se puede procesar los datos, favor revisar el nombre, nombre físico y tipo de catálogo", "Error con datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
