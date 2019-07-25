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

namespace DMS.RevisionUsuarios.InformesEmpleados
{
    public partial class InformeUsuariosFinal : Form
    {
        public InformeUsuariosFinal()
        {
            InitializeComponent();
            llenarEsquemas();
            obtenerCatalogos();


            lstCategorias.SelectedIndexChanged += LstCategorias_SelectedIndexChanged;
            txtBuscarCatalogo.KeyPress += TxtBuscarCatalogo_KeyPress;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            dtgCatalogos.SelectionChanged += DtgCatalogos_SelectionChanged;

            txtBusquedaGenerica.KeyPress += TxtBusquedaGenerica_KeyPress;

            cmbScriptsDisponibles.SelectedIndexChanged += CmbScriptsDisponibles_SelectedIndexChanged;



            dtgCatalogos.DoubleClick += DtgCatalogos_DoubleClick;


        }

        private void TxtBusquedaGenerica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (UtilidadesDesktop.TextboxProcess.PressEnter(e))
            {
                dataGridView1.Visible = true;
                var dato = cmbScriptsDisponibles.SelectedItem;

                try
                {
                    StringBuilder strb = new StringBuilder();
                    strb.Append(UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "ScriptExecute").ToString());
                    richTextBox1.Text = UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "Descripcion").ToString();
                    if (strb.ToString().Contains("@pBusqueda"))
                    {
                        txtBusquedaGenerica.Enabled = true;
                    }
                    else
                        txtBusquedaGenerica.Enabled = false;

                    dataGridView1.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).executeQuery(strb.ToString().Replace("@pBusqueda", (" '" + txtBusquedaGenerica.Text + "'")));
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    labelTotal.Text = "Total de registros: " + dataGridView1.Rows.Count.ToString();


                }
                catch (Exception ex)
                {
                    dataGridView1.Visible = false;
                    labelTotal.Text = String.Empty;
                }
            }
        }

        private void CmbScriptsDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusquedaGenerica.Text = String.Empty;
            dataGridView1.Visible = true;
            var dato = cmbScriptsDisponibles.SelectedItem;

            try
            {
                StringBuilder strb = new StringBuilder();
                strb.Append(UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "ScriptExecute").ToString());
                richTextBox1.Text = UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "Descripcion").ToString();
                if (strb.ToString().Contains("@pBusqueda"))
                {
                    txtBusquedaGenerica.Enabled = true;
                }
                else
                    txtBusquedaGenerica.Enabled = false;

                dataGridView1.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).executeQuery(strb.ToString().Replace("@pBusqueda", (" '" + txtBusquedaGenerica.Text + "'")));
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                labelTotal.Text = "Total de registros: " +dataGridView1.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                dataGridView1.Visible = false;
                labelTotal.Text = String.Empty;
            }

        }

        private void DtgCatalogos_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void DtgCatalogos_SelectionChanged(object sender, EventArgs e)
        {
            ///IdCategoria
            ///
            var dato = (new Servicio.CatalogoServiceImpl()).obtenerCatalogo(Convert.ToInt64(UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "IdCatalogo").ToString()));
            var objeto = (new Servicio.CatalogoServiceImpl()).listaScripts(dato.CodigoCatalogo);
            try
            {
                UtilidadesDesktop.ComboboxUtilities.fillCombobox(objeto, (new Modelos.ConsultasPorCatalogo()), ref cmbScriptsDisponibles);
            }
            catch (Exception ex)
            {

            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgCatalogos.Rows.Count == Convert.ToInt16(((TabControl)sender).SelectedTab.Tag.ToString()))
                {
                    tabControl1.SelectedTab = tabPage1;
                }

            }
            catch (Exception ex)
            {
                tabControl1.SelectedTab = tabPage1;
            }

        }

        private void TxtBuscarCatalogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (UtilidadesDesktop.TextboxProcess.PressEnter(e))
                obtenerCatalogos(); 
        }

        private void LstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerCatalogos();
        }

        void llenarEsquemas()
        {
            DMS.UtilidadesDesktop.ListBoxUtilities.fill(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref lstCategorias);
            for (int i = 0; i < lstCategorias.Items.Count; i++)
                lstCategorias.SetSelected(i, true);
        }

        private void obtenerCatalogos()
        {

            try
            {


                List<string> result = new List<string>();
                foreach (TipoCategoria item in lstCategorias.SelectedItems)
                {
                    result.Add(item.EsquemaFisico);
                }

                dtgCatalogos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgCatalogos.AutoGenerateColumns = false;
                if (rdbtnTodos.Checked)
                    dtgCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcionConScripts(txtBuscarCatalogo.Text, result.ToArray());
                else
                {
                    //rdbtnActivo.Checked
                    dtgCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcionConScripts(txtBuscarCatalogo.Text, result.ToArray(), rdbtnActivo.Checked);
                }
            }
            catch
            {
            }


        }

    }
}
