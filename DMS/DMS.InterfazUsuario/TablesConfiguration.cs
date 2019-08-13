using DMS.Modelos;
using DMS.Servicio;
using DMS.UtilidadesDesktop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.InterfazUsuario
{
    public partial class TablesConfiguration : Form
    {
        private bool creandoNuevo { get; set; }
        private int currentRowIndex { get; set; }

        bool refrescarDatos { get; set; }

        private Catalogos catalogoGeneral = new Catalogos();

        public TablesConfiguration()
        {
            InitializeComponent();
            creandoNuevo = false;
            currentRowIndex = -1;
            refrescarDatos = false;

            DMS.UtilidadesDesktop.ListBoxUtilities.fill(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref lstCategorias);

            for (int i = 0; i < lstCategorias.Items.Count; i++)
                lstCategorias.SetSelected(i, true);

            obtenerTipoCatalogos();
            obtenerCatalogos();



            #region "Datos de eventos"

            txtBuscarCatalogo.KeyPress += TxtBuscarCatalogo_KeyPress;
            dtgCatalogos.SelectionChanged += DtgCatalogos_SelectionChanged;
            //dtgCatalogos.DoubleClick += DtgCatalogos_DoubleClick;
            //dtgCatalogos.CellDoubleClick += DtgCatalogos_DoubleClick;
            txtBusquedaTabla.KeyPress += TxtBusquedaTabla_KeyPress;
            dtgCatalogos.CellMouseDoubleClick += DtgCatalogos_DoubleClick;
            btnNuevo.Click += BtnNuevo_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnAgregarCampo.Click += BtnAgregarCampo_Click;
            tabControlGeneral.SelectedIndexChanged += tabControlGeneral_SelectedIndexChanged;
            btnActualizarCampos.Click += BtnActualizarCampos_Click;
            dtgLLavePrimaria.CellClick += DtgLLavePrimaria_CellClick;
            dtgBusquedaCatalogos.CellDoubleClick += DtbBusquedaCatalogos_CellDoubleClick;
            lstColumnas.SelectedValueChanged += LstColumnas_SelectedValueChanged;
            lstCategorias.SelectedIndexChanged += LstCategorias_SelectedIndexChanged;
            lstCampoHacerReferencia.MouseDoubleClick += LstCampoHacerReferencia_MouseDoubleClick;
            dtgDetalleColumnas.DoubleClick += DtgDetalleColumnas_DoubleClick;
            btnEliminarScript.Click += BtnEliminarScript_Click;
            btnAgregarScript.Click += BtnAgregarScript_Click;
            btnCopy.Click += BtnCopy_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnQuitarRelacion.Click += BtnQuitarRelacion_Click;
            btnGuardarScript.Click += BtnGuardarScript_Click;
            lstCatalogosPK.SelectedIndexChanged += LstCamposPK_SelectedIndexChanged;
            btnEditar.Click += BtnEditar_Click;
            rdbtnTodos.CheckedChanged += RdbtnTodos_CheckedChanged;
            rdbtnActivo.CheckedChanged += RdbtnTodos_CheckedChanged;
            rdbtnInactivo.CheckedChanged += RdbtnTodos_CheckedChanged;

            btnAgregarReferencia.Click += BtnAgregarReferencia_Click;

            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            lstScripts.SelectedIndexChanged += LstScripts_SelectedIndexChanged;
            lstColumnasPK.SelectedIndexChanged += LstColumnasPK_SelectedIndexChanged;
            cmbPosiblesCampos.SelectedValueChanged += CbPosiblesCampos_SelectedValueChanged;
            txtBusquedaGeneral.KeyPress += TxtBusquedaGeneral_KeyPress;

            btnEliminarRelacionColumna.Click += BtnEliminarRelacionColumna_Click;
            richScriptExecute.TextChanged += RichScriptExecute_TextChanged;

            #endregion

            refrescarDatos = true; 

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CreacionEstructura.NuevoCatalogo nuevo = new CreacionEstructura.NuevoCatalogo(catalogoGeneral);
            nuevo.Show();

            catalogoGeneral = nuevo.catalogoActualizar;

            try
            {
                ObtenerInformacionCatalogo(catalogoGeneral);
            }
            catch
            {
            }


        }

        private void BtnEliminarRelacionColumna_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Quitar la relación al campo: " + UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "ValorMostrarCampo").ToString() + "?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    (new Servicio.CatalogoRelacionesServicieImpl()).agregarRelacionColumna(
                        Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "IdRelacionCatalogo").ToString()),
                        Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "CatalogoCampoId").ToString()),
                        null);

                }
                catch (Exception ex)
                {
                    UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                }


            }
        }

        bool validar = true; 
        private void CbPosiblesCampos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (validar)
            {
                if (DialogResult.Yes == MessageBox.Show("Agregar la relación al campo: " + UtilidadesDesktop.StringUtilities.getValueOfObject(cmbPosiblesCampos.SelectedItem, "NombreTecnico").ToString() + "?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        (new Servicio.CatalogoRelacionesServicieImpl()).agregarRelacionColumna(
                            Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "IdRelacionCatalogo").ToString()),
                            Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "CatalogoCampoId").ToString()),
                            Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(cmbPosiblesCampos.SelectedItem, "CatalogoCampoId").ToString())
                            );

                    }
                    catch (Exception ex)
                    {
                        UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                    }
                    

                }
            }
        }

        private void LstColumnasPK_SelectedIndexChanged(object sender, EventArgs e)
        {
                var resultado = (new Servicio.CatalogoRelacionesServicieImpl()).columnasParaAsignarComoFK(Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "IdRelacionCatalogo")));
                validar = false;
                UtilidadesDesktop.ComboboxUtilities.fillCombobox(resultado, ref cmbPosiblesCampos, "NombreCampoMostrar", "CatalogoCampoId");
                UtilidadesDesktop.ComboboxUtilities.fillComboboxSuggest(resultado, ref cmbPosiblesCampos, "NombreCampoMostrar", "CatalogoCampoId");

                ////CatalogoCampoIdFK
                /***************************************************************************************/
                var dato = UtilidadesDesktop.StringUtilities.getValueOfObject(lstColumnasPK.SelectedItem, "CatalogoCampoIdFK");
                if (dato != null)
                {
                    Modelos.CamposCatalogo campo = new CamposCatalogo();
                    campo.CodigoCampoCatalogo = Convert.ToInt64(dato);
                    var result = (new Servicio.ColumnasTablaServiceImpl()).obtenePorId(campo);
                    richTextBox1.Text = JsonConvert.SerializeObject(result);

                    for (int i = 0; i < cmbPosiblesCampos.Items.Count; i++)
                    {
                        if (Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(cmbPosiblesCampos.Items[i], "CatalogoCampoId")) == result.CodigoCampoCatalogo)
                        {
                            cmbPosiblesCampos.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    richTextBox1.Text = "{ No Tiene Relacion }";
                }
                /***************************************************************************************/
                validar = true;
            
        }

        private void BtnAgregarReferencia_Click(object sender, EventArgs e)
        {
            CreacionEstructura.SeleccionarTabla sel = new CreacionEstructura.SeleccionarTabla(catalogoGeneral);
            sel.ShowDialog();
            ObtenerTablasRelacionadas(); 
        }

        private void LstCamposPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var objeto = (new DMS.Servicio.CatalogoRelacionesServicieImpl()).obtenerColumnasTablasRelacionadas(catalogoGeneral.CodigoCatalogo, Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(lstCatalogosPK.SelectedItem, "IdRelacionCatalogo")));

                try
                {
                    var validarTemp = validar; 
                    validar = false; 
                    UtilidadesDesktop.ListBoxUtilities.fill(objeto, ref lstColumnasPK, "ValorMostrarCampo", "CatalogoCampoId");

                    validar = validarTemp;
                }
                catch (Exception ex)
                {
                    
                }
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        private void DtgDetalleColumnas_DoubleClick(object sender, EventArgs e)
        {
            var dato = new Modelos.CamposCatalogo();
            dato.CodigoCampoCatalogo = Convert.ToInt16(DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgDetalleColumnas, "CatalogoCampoId").ToString());
            var campo = (new Servicio.ColumnasTablaServiceImpl()).obtenePorId(dato);

            CreacionEstructura.CamposCatalogo campos = new CreacionEstructura.CamposCatalogo(catalogoGeneral, campo);
            campos.ShowDialog();
            btnActualizarCampos.PerformClick();

            try
            {
                dataGridView2.Visible = true;
                dataGridView2.DataSource = (new Servicio.CatalogoServiceImpl()).executeQuery(StringUtilities.getSqlQuery("[" + catalogoGeneral.TipoCategoria.EsquemaFisico + "].[" + txtNombreFisicoCatalogo.Text + "]", dtgDetalleColumnas, numericUpDown1.Value));

            }
            catch (Exception ex)
            {
                dataGridView2.Visible = false;
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Visible = true;
                dataGridView2.DataSource = (new Servicio.CatalogoServiceImpl()).executeQuery(StringUtilities.getSqlQuery("[" + catalogoGeneral.TipoCategoria.EsquemaFisico + "].[" + txtNombreFisicoCatalogo.Text + "]", dtgDetalleColumnas, numericUpDown1.Value));

            }
            catch (Exception ex)
            {
                dataGridView2.Visible = false;
            }

        }

        private void RichScriptExecute_TextChanged(object sender, EventArgs e)
        {
            UtilidadesDesktop.RichTextBoxUtilities.Pintar(richScriptExecute.Text, new string[] {
                "public", "private", "abstract", "namespace", "using", "if", "else", "throw", "try","SELECT","ISNUMERIC","SELECT","FROM","WHERE" }, ref richScriptExecute);
        }

        private void TxtBusquedaGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (UtilidadesDesktop.TextboxProcess.PressEnter(e))
            {
                dataGridView1.DataSource = (new Servicio.ColumnasTablaServiceImpl()).busquedaGeneral(txtBusquedaGeneral.Text);
                dataGridView1.Columns["IdCatalogo"].Visible = false;
                dataGridView1.Columns["IdCategoria"].Visible = false;
                dataGridView1.Columns["Nombre"].Visible = false;
                dataGridView1.Columns["TotalEsperado"].Visible = false;
                dataGridView1.Columns["TotalObligatorio"].Visible = false;
                dataGridView1.Columns["Activa"].Visible = false;
                dataGridView1.Columns["TablaCreada"].Visible = false;
                dataGridView1.Columns["Activo"].Visible = false;
                dataGridView1.Columns["CatalogoCampoId"].Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 

            }
        }

        private void LstScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dato = lstScripts.SelectedItem;
                richScriptExecute.Text = UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "ScriptExecute").ToString();

            }
            catch (Exception)
            {
                richScriptExecute.Text = String.Empty; 
            }
        }

        private void BtnGuardarScript_Click(object sender, EventArgs e)
        {
            try
            {
                var dato = (lstScripts.SelectedItem);

                ConsultasPorCatalogo consultaCatalogo = new ConsultasPorCatalogo();
                consultaCatalogo.Catalogo = catalogoGeneral;
                consultaCatalogo.IdCatalogoConsulta = Convert.ToInt16(UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "IdCatalogoConsulta"));
                consultaCatalogo.Nombre = UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "Nombre").ToString();
                consultaCatalogo.Descripcion = UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "Descripcion").ToString();
                consultaCatalogo.Activo = Convert.ToBoolean(UtilidadesDesktop.StringUtilities.getValueOfObject(dato, "Activo"));
                consultaCatalogo.ScriptExecute = richScriptExecute.Text;

                (new Servicio.CatalogoServiceImpl()).actualizarScript(consultaCatalogo);
                UtilidadesDesktop.MessageBoxUtilities.registroAlmacenadoCorrectamente();
                ActualizarScripts();

            }
            catch (Exception ex)
            {
                UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
            }
        }

        private void ActualizarScripts()
        {
            try
            {
                DMS.UtilidadesDesktop.ListBoxUtilities.fill((new DMS.Servicio.CatalogoServiceImpl().listaScripts(catalogoGeneral.CodigoCatalogo)), (new DMS.Modelos.ConsultasPorCatalogo()), ref lstScripts);
            }
            catch (Exception)
            {

            }
            if (lstScripts.Items.Count == 0)
            {
                richScriptExecute.Text = String.Empty; 
            }

        }
        private void BtnAgregarScript_Click(object sender, EventArgs e)
        {
            CreacionEstructura.frmListaScripts list = new CreacionEstructura.frmListaScripts(catalogoGeneral);
            list.ShowDialog();
            ActualizarScripts(); 
        }

        private void BtnEliminarScript_Click(object sender, EventArgs e)
        {
            if (lstScripts.Items.Count > 0)
            {

            }

        }

        private void RdbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                obtenerCatalogos();
            }
        }

        private void BtnQuitarRelacion_Click(object sender, EventArgs e)
        {
            if (dtgRelaciones.Rows.Count > 0)
            {
                if (DialogResult.Yes == UtilidadesDesktop.MessageBoxUtilities.mensajePreguntaBorrar(catalogoGeneral.NombreFisico + " - " + DatagridViewUtilities.ObtenerValorCeldaActual(dtgRelaciones, "NombreCampoCatalogoBase").ToString()))
                {

                    try
                    {
                        (new DMS.Servicio.ColumnasTablaServiceImpl()).quitarAsociacionCampos(
                        Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgRelaciones, "CodigoCatalogoBase")),
                        Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgRelaciones, "CodigoCataloReferencia")));
                        MessageBoxUtilities.registroAlmacenadoCorrectamente();
                        ObtenerRelaciones(); 

                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtilities.errorAlmacenarRegistros(ex);
                    }
                    
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDetalleColumnas.Rows.Count > 0)
            {
                if (UtilidadesDesktop.MessageBoxUtilities.mensajePreguntaBorrar(catalogoGeneral.NombreFisico) == DialogResult.Yes)
                {
                    if (!chkPendienteCrear.Checked)
                    {
                        (new DMS.Servicio.ColumnasTablaServiceImpl()).eliminarCampo(Convert.ToInt64(UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgDetalleColumnas, "CatalogoCampoId")));
                    }
                    else {
                        (new DMS.Servicio.ColumnasTablaServiceImpl()).desactivarCampo(Convert.ToInt64(UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgDetalleColumnas, "CatalogoCampoId")),false);

                    }
                    ObtenerInformacionCatalogo();
                }
            }
        }

        private void LstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerCatalogos();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            CreacionEstructura.CopiarColumna copiar = new CreacionEstructura.CopiarColumna(catalogoPadre);
            copiar.CatalogoBase = catalogoPadre; 
            copiar.ShowDialog();
            ObtenerInformacionCatalogo(); 
        }

        private void LstCampoHacerReferencia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updateRelation(); 
        }

        private void LstColumnas_SelectedValueChanged(object sender, EventArgs e)
        {
            ObtenerRelaciones(); 
        }

        private void DtbBusquedaCatalogos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerInformacionCatalogosReferencias();
        }

        private void TxtBusquedaTabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DMS.UtilidadesDesktop.TextboxProcess.PressEnter(e))
            {
                obtenerCatalogosReferencia();
            }
        }

        private void DtgLLavePrimaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgLLavePrimaria.Columns[this.dtgLLavePrimaria.CurrentCell.ColumnIndex].Name == "dtLlavePrimaria")
            {
                DMS.Modelos.CamposCatalogo campo = new CamposCatalogo();
                try
                {
                    campo.CodigoCampoCatalogo = Convert.ToInt64(DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgLLavePrimaria, "dtCatalogoCampoId"));
                    campo.LlavePrimaria = !Convert.ToBoolean(DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgLLavePrimaria, "dtLlavePrimaria"));
                    (new DMS.Servicio.ColumnasTablaServiceImpl()).actualizarPK(campo);
                }
                catch (Exception ex)
                {
                }
                ObtenerInformacionCatalogo();

            }
        }

        private void BtnActualizarCampos_Click(object sender, EventArgs e)
        {
            ObtenerInformacionCatalogo(); 
        }

        private void BtnAgregarCampo_Click(object sender, EventArgs e)
        {
            CreacionEstructura.CamposCatalogo cat = new CreacionEstructura.CamposCatalogo(catalogoGeneral);
            cat.ShowDialog();
            ObtenerInformacionCatalogo(); 
        }

        private void DtgCatalogos_DoubleClick(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabPageDetalleCatalogo;
            tabControl2.SelectedTab = tabPage3;
        }

        private void tabControlGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (creandoNuevo)
            {
                tabControlGeneral.SelectedTab = tabPageDetalleCatalogo;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBoxUtilities.mensajePreguntaGuardar("Catalgo tablas") == DialogResult.Yes)
            {
                try
                {
                    DMS.Modelos.Catalogos catalogo = new Modelos.Catalogos();
                    catalogo.NombreCatalogo = txtNombreCatalogo.Text;
                    catalogo.TablaCreada = chkPendienteCrear.Checked;
                    catalogo.Activo = chkActivo.Checked;
                    catalogo.TablaReferenciada = false;
                    catalogo.ListoParaCrear = chkListoCrear.Checked;
                    catalogo.TipoCategoria = (TipoCategoria)cmbTipoCatalogo.SelectedItem;
                    catalogo.NombreFisico = txtNombreFisicoCatalogo.Text;
                    if (txtCodigoCatalogo.Text != "")
                    {
                        catalogo.CodigoCatalogo = Convert.ToInt64(txtCodigoCatalogo.Text);
                    }
                    else
                        catalogo.CodigoCatalogo = 0;

                    if (catalogo.CodigoCatalogo > 0)
                        (new DMS.Servicio.CatalogoServiceImpl()).actualizarCatalogo(catalogo);
                    else
                        (new DMS.Servicio.CatalogoServiceImpl()).nuevo(catalogo);
                    MessageBoxUtilities.registroAlmacenadoCorrectamente();
                    txtBuscarCatalogo.Text = catalogo.NombreCatalogo;

                    creandoNuevo = false;
                    btnNuevo.Text = "Nuevo";
                    obtenerCatalogos(); 

                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.errorAlmacenarRegistros(ex); 
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //if (!creandoNuevo)
            //{
            //    creandoNuevo = true;
            //    LimpiarDatos(); 
            //    btnNuevo.Text = "Cancelar";
            //}
            //else {
            //    creandoNuevo = false;
            //    btnNuevo.Text = "Nuevo";
            //    ObtenerInformacionCatalogo(); 
            //}
            CreacionEstructura.NuevoCatalogo nuevo = new CreacionEstructura.NuevoCatalogo();
            nuevo.ShowDialog();
            catalogoGeneral = nuevo.catalogoActualizar;

            try
            {
                ObtenerInformacionCatalogo(catalogoGeneral);
            }
            catch
            {
            }


        }

        private void DtgCatalogos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ObtenerInformacionCatalogo();
            }
            catch
            {
            }
        }

        private void TxtBuscarCatalogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DMS.UtilidadesDesktop.TextboxProcess.PressEnter(e))
            {
                obtenerCatalogos();
            }
        }

        private void obtenerCatalogos()
        {

            try
            {
                

                refrescarDatos = false;
                List<string> result = new List<string>();
                foreach (TipoCategoria item in lstCategorias.SelectedItems)
                {
                    result.Add(item.EsquemaFisico);
                }

                dtgCatalogos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgCatalogos.AutoGenerateColumns = false;
                if (rdbtnTodos.Checked)
                    dtgCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcion(txtBuscarCatalogo.Text, result.ToArray());
                else
                {
                    //rdbtnActivo.Checked
                    dtgCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcion(txtBuscarCatalogo.Text, result.ToArray(), rdbtnActivo.Checked);
                }
                ObtenerInformacionCatalogo();
                try
                {
                    ActualizarScripts();

                }
                catch (Exception ex)
                {
                }

                refrescarDatos = true;
            }
            catch
            {
            }
        }
        

        private void obtenerCatalogosReferencia()
        {
            try
            {
                dtgBusquedaCatalogos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgBusquedaCatalogos.AutoGenerateColumns = false;
                dtgBusquedaCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcionActivos(txtBusquedaTabla.Text);
            }
            catch
            {
            }

        }

        private void obtenerTipoCatalogos()
        {
            catalogoGeneral = new Catalogos();
            DMS.UtilidadesDesktop.ComboboxUtilities.fillCombobox(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref cmbTipoCatalogo);
        }

        public void LimpiarDatos()
        {
            catalogoGeneral = new Catalogos(); 
            txtCodigoCatalogo.Text = 
                txtNombreCatalogo.Text = 
                txtNombreFisicoCatalogo.Text = String.Empty;
            cmbTipoCatalogo.Enabled = true; 

            txtNombreCatalogo.Enabled = txtNombreFisicoCatalogo.Enabled = true;
            obtenerTipoCatalogos();
            chkPendienteCrear.Checked = chkReferenciaDesdeOtra.Checked = false;
            dtgLLavePrimaria.Rows.Clear();
            chkActivo.Checked = false;
        }
        public void validarReferencias()
        {
            int erroresReferencia = 0; 
            try
            {
                dtgErroresReferencia.DataSource = (new Servicio.ColumnasTablaServiceImpl().erroresAsociaciones((int)catalogoGeneral.CodigoCatalogo));
                dtgErroresReferencia.Columns["CatalogoCampoIdPK"].Visible = false;
                tabPage6.Text = "";
                for (int i = 0; i < dtgErroresReferencia.Rows.Count; i++)
                {
                    if (dtgErroresReferencia.Rows[i].Cells["DetalleError"].Value.ToString().Length > 0)
                    {
                        erroresReferencia++;
                    }
                }

            }
            catch (Exception)
            {

            }
            tabPage6.Text = "Errores de llaves Foraneas (" + erroresReferencia + ")";
        }
        private Catalogos catalogoPadre { get; set; }
        public void ObtenerInformacionCatalogo()
        {
            try
            {
                Catalogos catalogos = new Catalogos();
                catalogos = (new DMS.Servicio.CatalogoServiceImpl()).obtenerCatalogo(Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "IdCatalogo").ToString()));
                var categoriaActual = catalogos.TipoCategoria;
                catalogoGeneral = catalogos;


                txtCodigoCatalogo.Text = catalogos.CodigoCatalogo.ToString();
                txtNombreCatalogo.Text = catalogos.NombreCatalogo;
                txtNombreFisicoCatalogo.Text = catalogos.NombreFisico;
                txtNombreFisicoCatalogo.Enabled = false;
                chkActivo.Checked = catalogos.Activo;
                chkPendienteCrear.Checked = catalogos.TablaCreada;
                chkReferenciaDesdeOtra.Checked = catalogos.TablaReferenciada;
                chkListoCrear.Checked = catalogos.ListoParaCrear;
                
                for (int i = 0; i < cmbTipoCatalogo.Items.Count; i++)
                {
                    if (((TipoCategoria)cmbTipoCatalogo.Items[i]).Codigo == categoriaActual.Codigo)
                        cmbTipoCatalogo.SelectedIndex = i;
                }
                cmbTipoCatalogo.Enabled = !chkPendienteCrear.Checked;
                ObtenerTablasRelacionadas();
                try
                {
                    ActualizarScripts(); 
                }
                catch (Exception)
                {
                }
                catalogoPadre = catalogos;
                ObtenerColumnasListBox(); 

                mostrarRelaciones();
                validarReferencias();
            }
            catch (Exception ex)
            {
                LimpiarDatos();
            }


        }

        public void ObtenerInformacionCatalogo(Catalogos catalogo)
        {
            try
            {
                catalogoGeneral = (new Servicio.CatalogoServiceImpl()).obtenerCatalogo(catalogo.CodigoCatalogo);

                txtCodigoCatalogo.Text = catalogoGeneral.CodigoCatalogo.ToString();
                txtNombreCatalogo.Text = catalogoGeneral.NombreCatalogo;
                txtNombreFisicoCatalogo.Text = catalogoGeneral.NombreFisico;
                txtNombreFisicoCatalogo.Enabled = !catalogoGeneral.TablaCreada;
                chkActivo.Checked = catalogoGeneral.Activo;
                chkPendienteCrear.Checked = catalogoGeneral.TablaCreada;
                chkReferenciaDesdeOtra.Checked = catalogoGeneral.TablaReferenciada;
                chkListoCrear.Checked = catalogoGeneral.ListoParaCrear;

                for (int i = 0; i < cmbTipoCatalogo.Items.Count; i++)
                {
                    if (((TipoCategoria)cmbTipoCatalogo.Items[i]).Codigo == catalogoGeneral.TipoCategoria.Codigo)
                        cmbTipoCatalogo.SelectedIndex = i;
                }
                cmbTipoCatalogo.Enabled = !chkPendienteCrear.Checked;
                ObtenerTablasRelacionadas();
                try
                {
                    ActualizarScripts();
                }
                catch (Exception)
                {
                }
                catalogoPadre = catalogoGeneral;
                ObtenerColumnasListBox();

                mostrarRelaciones();
                validarReferencias();
            }
            catch (Exception ex)
            {
                LimpiarDatos();
            }


        }
        private void ObtenerTablasRelacionadas()
        {
            try
            {
                lstCatalogosPK.Visible = true; 
                var dato = (new CatalogoRelacionesServicieImpl()).obtenerTablasRelacionadas(catalogoGeneral.CodigoCatalogo);
                UtilidadesDesktop.ListBoxUtilities.fill(dato, ref lstCatalogosPK, "ValorMostrarCatalogo", "IdRelacionCatalogo");
                richTextBox1.Text = String.Empty;
                if (lstCatalogosPK.Items.Count > 0)
                {
                    lstColumnasPK.Visible = cmbPosiblesCampos.Visible = true; 
                }
                else
                    lstColumnasPK.Visible = cmbPosiblesCampos.Visible = false;

            }
            catch (Exception)
            {
                lstCatalogosPK.Visible = lstColumnasPK.Visible = cmbPosiblesCampos.Visible = false;

            }
        }
        public void ObtenerColumnasListBox()
        {

            var objeto = (new DMS.Servicio.ColumnasTablaServiceImpl()).columnasTabla(catalogoPadre);
            
            try
            {
                DMS.UtilidadesDesktop.DatagridViewUtilities.llenarDatagridView(objeto, ref dtgDetalleColumnas, false);
                ListBoxUtilities.fill(objeto, ref lstColumnas, "NameWithTechnicalCode", "CatalogoCampoId");

                fillPrimaryKeyINfo(objeto);

            }
            catch (Exception ex)
            {
            }

        }
        public void mostrarRelaciones()
        {
            bool mostrarPendienteCrear = false;
            try
            {
                dataGridView2.Visible = true;
                dataGridView2.DataSource = (new Servicio.CatalogoServiceImpl()).executeQuery(StringUtilities.getSqlQuery("[" + catalogoGeneral.TipoCategoria.EsquemaFisico + "].[" + txtNombreFisicoCatalogo.Text + "]", dtgDetalleColumnas,(int)numericUpDown1.Value));
                mostrarPendienteCrear = true;
            }
            catch (Exception ex)
            {
                dataGridView2.Visible = false;
            }

            if (mostrarPendienteCrear)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    chkPendienteCrear.Enabled = false;
                    chkListoCrear.Enabled = false;
                }
                else
                {
                    chkPendienteCrear.Enabled = true;
                    chkListoCrear.Enabled = true;
                }
            }
            else
            {
                chkPendienteCrear.Enabled = true;
                chkListoCrear.Enabled = true;
            }
        }
        public void obtenerInformacionCatalogosReferencias()
        {
            Catalogos catalogosLlave = new Catalogos();
            catalogosLlave.CodigoCatalogo = Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameIdCatalogo").ToString());
            catalogosLlave.NombreCatalogo = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameNombreCatalogo").ToString();
            catalogosLlave.NombreFisico = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameNombreFisicoCatalogo").ToString();

            //ListoParaCrear

            var result = (new Servicio.ColumnasTablaServiceImpl()).columnasTablaPK(catalogosLlave);
            ListBoxUtilities.fill(result, ref lstCampoHacerReferencia, "NameWithTechnicalCode", "CatalogoCampoId");

            //UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, ""); 

        }
        private void fillPrimaryKeyINfo(List<Object> objects)
        {
            dtgLLavePrimaria.Rows.Clear(); 
            if (objects.Count > 0)
            {
                Type myType = objects[0].GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
                foreach (var item in objects)
                {
                    string CatalogoCampoId = String.Empty;
                    string NombreCampo = string.Empty;
                    string NombreTecnico = string.Empty;
                    string TipoDato = string.Empty;
                    bool LlavePrimaria = false; 
                    foreach (PropertyInfo prop in props)
                    {
                        switch (prop.Name)
                        {
                            case "CatalogoCampoId":
                                CatalogoCampoId = prop.GetValue(item, null).ToString();
                                break;
                            case "NombreCampo":
                                NombreCampo = prop.GetValue(item, null).ToString();
                                break;
                            case "NombreTecnico":
                                NombreTecnico = prop.GetValue(item, null).ToString();
                                break;
                            case "TipoDato":
                                TipoDato = prop.GetValue(item, null).ToString();
                                break;
                            case "LlavePrimaria":
                                LlavePrimaria = DMS.UtilidadesDesktop.StringUtilities.convertirStringBool(prop.GetValue(item, null).ToString());
                                break;

                        }
                        // Do something with propValue
                    }
                    dtgLLavePrimaria.Rows.Add(CatalogoCampoId, NombreCampo, NombreTecnico, TipoDato, LlavePrimaria);

                }
            }



        }

        private void ObtenerRelaciones()
        {
            Modelos.CamposCatalogo campo = new CamposCatalogo();
            try
            {
                var objeto = lstColumnas.SelectedItem;
                var dato = UtilidadesDesktop.StringUtilities.getValueOfObject(objeto, "CatalogoCampoId");
                campo.CodigoCampoCatalogo = Convert.ToInt64(dato);

            }
            catch (Exception ex)
            {
                campo.CodigoCampoCatalogo = 0; 

            }
            var resultado = (new Servicio.ColumnasTablaServiceImpl()).obtenerAsociacionesColumna(campo);
            UtilidadesDesktop.DatagridViewUtilities.llenarDatagridView(resultado, ref dtgRelaciones, false);


        }

        private void updateRelation()
        {
                var campoReferencia = lstColumnas.SelectedItem;
                var campoPK = lstCampoHacerReferencia.SelectedItem;

                CamposCatalogo camposCatalogoReferencia = new CamposCatalogo();
                camposCatalogoReferencia.CodigoCampoCatalogo = Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(campoReferencia, "CatalogoCampoId"));

                CamposCatalogo camposCatalogoPK = new CamposCatalogo();
                camposCatalogoPK.CodigoCampoCatalogo = Convert.ToInt64(UtilidadesDesktop.StringUtilities.getValueOfObject(campoPK, "CatalogoCampoId"));

                try
                {
                    (new Servicio.ColumnasTablaServiceImpl()).crearAsociacionCampos(camposCatalogoReferencia, camposCatalogoPK);
                }
                catch (Exception ex)
                {
                    UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex); 
                }
          

            ObtenerRelaciones(); 
        }

    }
}
