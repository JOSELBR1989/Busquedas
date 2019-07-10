using Busquedas.modelo;
using Busquedas.modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busquedas.Sistema
{
    public partial class Form1 : Form
    {
        private long cantidadaRegistros { get; set; }
        private int cantidadPaginas { get; set; }
        private int unidadesPagina { get; set; }
        private bool actualizarInformacion { get; set; }

        private int currentRowSelected { get; set; }
        public Form1()
        {
            InitializeComponent();
            rdLoteNo.CheckedChanged += RdActivosTodos_CheckedChanged;
            rdLoteSi.CheckedChanged += RdActivosTodos_CheckedChanged;
            rdLoteTodos.CheckedChanged += RdActivosTodos_CheckedChanged;

            rdMigrarSAPNo.CheckedChanged += RdActivosTodos_CheckedChanged;
            rdMigrarSAPSi.CheckedChanged += RdActivosTodos_CheckedChanged;
            rdMigrarSAPTodos.CheckedChanged += RdActivosTodos_CheckedChanged;

            rdActivosTodos.CheckedChanged += RdActivosTodos_CheckedChanged;
            rdActivosSi.CheckedChanged += RdActivosTodos_CheckedChanged;
            rdActivosNo.CheckedChanged += RdActivosTodos_CheckedChanged;
            

            List<FillValuesDisplayValueMember> value = new List<FillValuesDisplayValueMember>();
            value.Add(new FillValuesDisplayValueMember("NombreBase", "Nombre"));
            value.Add(new FillValuesDisplayValueMember("IdMaterial", "Codigo"));
            value.Add(new FillValuesDisplayValueMember("NombreCatalogo", "Catalogo"));
            //Codigo
            //NOmbre
            comboBox1.DataSource = value;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Codigo";
            btnAtras.Click += Navegacion;
            btnAdelante.Click += Navegacion;
            numHojaActual.ValueChanged += NumHojaActual_ValueChanged;
            NumRegistroPorLote.ValueChanged += NumRegistroPorLote_ValueChanged;
            actualizarInformacion = true;
            dtgMateriales.SelectionChanged += DtgMateriales_SelectionChanged;


            inicializar();
        }

        private void obtenerDatosMaterial()
        {
                StringBuilder str = new StringBuilder();
                str.AppendLine("{");
                str.AppendLine(string.Concat("\t'Sistema': ", dtgMateriales.Rows[currentRowSelected].Cells["NombreSistema"].Value.ToString(), ","));
                str.AppendLine(string.Concat("\t'Catalogo': ", dtgMateriales.Rows[currentRowSelected].Cells["NombreCatalogo"].Value.ToString(), ","));
                str.AppendLine(string.Concat("\t'Material': ", dtgMateriales.Rows[currentRowSelected].Cells["Nombre"].Value.ToString(), ","));
                str.AppendLine("}");
                this.richTextBox1.Text = str.ToString();

                servicios.MaterialServiceImpl mat = new servicios.MaterialServiceImpl();
                dtgEquivalentes.DataSource = mat.materialesEquivalentes(Convert.ToInt64(dtgMateriales.Rows[currentRowSelected].Cells["IdMaterial"].Value.ToString()));
                dtgEquivalentes.Columns["IdSistemaCatalogo"].Visible = false;
                dtgEquivalentes.Columns["NombreSistema"].Visible = false;
                dtgEquivalentes.Columns["NombreCatalogo"].Visible = false;
                dtgEquivalentes.Columns["ManejaLote"].Visible = false;
                dtgEquivalentes.Columns["DiasVencimiento"].Visible = false;
                dtgEquivalentes.Columns["Activo"].Visible = false;
                dtgEquivalentes.Columns["MigrarSap"].Visible = false;
                dtgEquivalentes.Columns["DescripcionAmpliada"].Visible = false;
                dtgEquivalentes.Columns["CompanyBuildId"].Visible = false;
                dtgEquivalentes.Columns["IdMaterialSistema"].Visible = false;
                dtgEquivalentes.Columns["Correlativo"].Visible = false;
                if (dtgEquivalentes.Rows.Count > 0)
                {
                    richTextBox2.Text = dtgEquivalentes.Rows[0].Cells["DescripcionAmpliada"].Value.ToString();
                }


            
        }
        private void DtgMateriales_SelectionChanged(object sender, EventArgs e)
        {
            if (currentRowSelected != this.dtgMateriales.CurrentCell.RowIndex)
            {
                currentRowSelected = this.dtgMateriales.CurrentCell.RowIndex;
                obtenerDatosMaterial();
            }
        }

        private void NumRegistroPorLote_ValueChanged(object sender, EventArgs e)
        {
            inicializar();
        }
        private void NumHojaActual_ValueChanged(object sender, EventArgs e)
        {
            if (actualizarInformacion)
                inicializar();
        }
        private void Navegacion(object sender, EventArgs e)
        {
            if (numHojaActual.Value + Convert.ToInt16(((Button)sender).Tag.ToString()) >= numHojaActual.Minimum &&
                numHojaActual.Value + Convert.ToInt16(((Button)sender).Tag.ToString())  <= numHojaActual.Maximum )
            {
                numHojaActual.Value = numHojaActual.Value + Convert.ToInt16(((Button)sender).Tag.ToString());
            }
        }
        private bool? getLote {
            get {
                if (rdLoteTodos.Checked)
                    return null;
                else if (rdLoteSi.Checked)
                    return true;
                else
                    return false;
            }
        }
        private bool? getMigrarSap
        {
            get {
                if (rdMigrarSAPTodos.Checked)
                    return null;
                else if (rdMigrarSAPSi.Checked)
                    return true;
                else
                    return false;
            }
        }
        private bool? getActivos
        {
            get {
                if (rdActivosTodos.Checked)
                    return null;
                else if (rdActivosSi.Checked)
                    return true;
                else
                    return false;
            }
        }
        private void RdActivosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                inicializar();
            }
        }


        void inicializar()
        {
            List<Material> datos = new List<Material>();
            Busquedas.servicios.MaterialServiceImpl mat = new servicios.MaterialServiceImpl();
            var totalRegistros = mat.obtenerTotalRegistros(getLote, getActivos, getMigrarSap, txtBusquedaMaterial.Text);
            if (totalRegistros.TotalRegistro != cantidadaRegistros)
            {
                label3.Text = "Total de registros (" + totalRegistros.TotalRegistro.ToString() + ")";
                numTotalPaginas.Value = Math.Ceiling(Convert.ToDecimal(totalRegistros.TotalRegistro) / NumRegistroPorLote.Value);
                cantidadPaginas = Convert.ToInt16(numTotalPaginas.Value);
                cantidadaRegistros = totalRegistros.TotalRegistro;
                numHojaActual.Minimum = 0;
                numHojaActual.Value = 0; 
                numHojaActual.Maximum = numTotalPaginas.Value;
                unidadesPagina = (int)NumRegistroPorLote.Value;
            }

            if (unidadesPagina != NumRegistroPorLote.Value)
            {
                numTotalPaginas.Value = Math.Ceiling(Convert.ToDecimal(totalRegistros.TotalRegistro) / NumRegistroPorLote.Value);
                cantidadPaginas = Convert.ToInt16(numTotalPaginas.Value);
                cantidadaRegistros = totalRegistros.TotalRegistro;
                numHojaActual.Maximum = numTotalPaginas.Value;
                unidadesPagina = (int)NumRegistroPorLote.Value;
                if ((int)numHojaActual.Value >= cantidadPaginas)
                {
                    numHojaActual.Value = cantidadPaginas; 
                }
            }

            try
            {
                datos =
                mat.porFiltrosBusqueda(getLote, getActivos, getMigrarSap, txtBusquedaMaterial.Text,
                (int)(numHojaActual.Value * NumRegistroPorLote.Value),
                (int)NumRegistroPorLote.Value,
                ((FillValuesDisplayValueMember)comboBox1.SelectedItem).Codigo);
                
                
            }
            catch (Exception ex)
            {
                datos = new List<Material>(); 
            }
            

            dtgMateriales.DataSource = datos;
            if (dtgMateriales.Rows.Count == 0)
            {
                groupBoxMostrar.Enabled = false;
                
            }
            else {
                currentRowSelected = 0; 
                obtenerDatosMaterial();
            }

            tabMaterialesBase.Text = "Materiales (" + dtgMateriales.Rows.Count.ToString() + ")";
            dtgMateriales.Columns["CodigoVisible"].Visible = false;
            dtgMateriales.Columns["IdSistemaCatalogo"].Visible = false;
            dtgMateriales.Columns["DescripcionAmpliada"].Visible = false; 
        }

    }
}
