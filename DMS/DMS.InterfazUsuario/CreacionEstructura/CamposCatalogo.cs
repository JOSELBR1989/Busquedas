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
    public partial class CamposCatalogo : Form
    {
        Catalogos catalogoPadre;
        CamposCatalogo camposCatalogo;
        public CamposCatalogo()
        {
            InitializeComponent();

            catalogoPadre = new Catalogos();
            if (catalogoPadre != null)
                btnGuardarRegistro.Enabled = true;
            else
                btnGuardarRegistro.Enabled = false;
        }
        public CamposCatalogo(Catalogos catalogo)
        {
            InitializeComponent();

            catalogoPadre = new Catalogos();
            catalogoPadre = catalogo;
            if (catalogoPadre != null)
                btnGuardarRegistro.Enabled = true;
            else
                btnGuardarRegistro.Enabled = false;
            lblEncabezadoCatalogo.Text = catalogoPadre.NombreCatalogo + " [" +  catalogoPadre.NombreFisico + "]";

            ResetEnabledNumeric(false,-1,-1,-1, numPresicion, numTamanio);
            obtenerAgrupaciones();


            txtNombreTecnicoColumna.KeyPress += TxtNombreTecnicoColumna_KeyPress;
            cmbTipoDato.SelectedValueChanged += CmbTipoDato_SelectedValueChanged;
            btnGuardarRegistro.Click += BtnGuardarRegistro_Click;
            txtOrden.KeyPress += TxtOrden_KeyPress;

        }

        public CamposCatalogo(Catalogos catalogo, DMS.Modelos.CamposCatalogo camposColumna)
        {
            InitializeComponent();

            catalogoPadre = new Catalogos();
            catalogoPadre = catalogo;
            if (catalogoPadre != null)
                btnGuardarRegistro.Enabled = true;
            else
                btnGuardarRegistro.Enabled = false;
            lblEncabezadoCatalogo.Text = catalogoPadre.NombreCatalogo + " [" + catalogoPadre.NombreFisico + "]";

            ResetEnabledNumeric(false, -1, -1, -1, numPresicion, numTamanio);


            txtNombreTecnicoColumna.KeyPress += TxtNombreTecnicoColumna_KeyPress;
            cmbTipoDato.SelectedValueChanged += CmbTipoDato_SelectedValueChanged;
            btnGuardarRegistro.Click += BtnGuardarRegistro_Click;
            txtOrden.KeyPress += TxtOrden_KeyPress;


        }

        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {

            }
            else
                guardarNuevoRegistro(); 

        }

        private void guardarNuevoRegistro()
        {
            if (DMS.UtilidadesDesktop.TextboxProcess.validarRequeridos(txtNombreColumna, txtNombreTecnicoColumna, txtOrden) &&
                    UtilidadesDesktop.ComboboxUtilities.selectedTextValidate(cmbTipoDato))
            {
                DMS.Modelos.CamposCatalogo campos = new Modelos.CamposCatalogo();
                if (cmbAgrupacion.Items.Count > 0)
                {

                }
                campos.Catalogo = catalogoPadre;
                campos.NombreCampo = txtNombreColumna.Text;
                campos.DescripcionCampo = txtDescripcionColumna.Text;
                campos.NombreTecnicoCampo = txtNombreTecnicoColumna.Text;
                campos.TipoDatoCampo = cmbTipoDato.Text;
                campos.Tamanio = (int)numTamanio.Value;
                campos.Presicion = (int)numPresicion.Value;
                campos.ConReferencia = false;
                campos.Requerido = chkRequerido.Checked;
                campos.LlavePrimaria = false;
                campos.Orden = Convert.ToInt16(txtOrden.Text);
                campos.Activo = true; 

                try
                {
                    (new DMS.Servicio.ColumnasTablaServiceImpl()).nuevo(campos);
                    this.Close();
                }
                catch (Exception ex)
                {
                    DMS.UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                }

            }
            else {
                string mensaje = "\n" + DMS.UtilidadesDesktop.TextboxProcess.tagsTextBoxString(txtNombreColumna, txtNombreTecnicoColumna, txtOrden);
                if (mensaje.Length > 0) mensaje = mensaje + ",";
                mensaje = mensaje + UtilidadesDesktop.ComboboxUtilities.tagsComboboxString(cmbTipoDato);
                UtilidadesDesktop.MessageBoxUtilities.camposIncompletos(mensaje);
            }



        }

        private void TxtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DMS.UtilidadesDesktop.TextboxProcess.isNumber(e); 
        }

        private void CmbTipoDato_SelectedValueChanged(object sender, EventArgs e)
        {
            ResetEnabledNumeric(false, -1, -1, -1, numPresicion, numTamanio);
            if (cmbTipoDato.Text == "NVARCHAR")
            {
                ResetEnabledNumeric(true, 1, 4000, 1, numTamanio);
            }
            else {
                if (cmbTipoDato.Text == "DECIMAL")
                {
                    ResetEnabledNumeric(true, 1, 8, 1, numPresicion);
                    ResetEnabledNumeric(true, 1, 4000, 1, numTamanio);
                }

            }
        }

        public void ResetEnabledNumeric(bool activo, int minNum, int maxNum, int defaultValue, params NumericUpDown[] numerics)
        {
            foreach (NumericUpDown num in numerics)
            {
                num.Enabled = activo;
                num.Minimum = minNum;
                num.Maximum = maxNum;
                num.Value = defaultValue;
            }
        }

        private void TxtNombreTecnicoColumna_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DMS.UtilidadesDesktop.TextboxProcess.pressCharOrDigit(e); 
        }

        private void obtenerAgrupaciones()
        {
            try
            {
                DMS.UtilidadesDesktop.ComboboxUtilities.fillCombobox((new List<DMS.Modelos.Agrupaciones>()).Cast<Object>().ToList(), (new Modelos.Agrupaciones()), ref cmbAgrupacion);
            }
            catch (Exception)
            {
            }
        }
        
        /*NVARCHAR
DECIMAL
DATE*/




    }
}
