using DMS.Modelos;
using DMS.Servicio;
using DMS.UtilidadesDesktop;
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

        private Catalogos catalogoGeneral = new Catalogos(); 

        public TablesConfiguration()
        {
            InitializeComponent();
            creandoNuevo = false;
            currentRowIndex = -1;
            obtenerCatalogos();
            obtenerTipoCatalogos();

            #region "Datos de "

            txtBuscarCatalogo.KeyPress += TxtBuscarCatalogo_KeyPress;
            dtgCatalogos.SelectionChanged += DtgCatalogos_SelectionChanged;
            //dtgCatalogos.DoubleClick += DtgCatalogos_DoubleClick;
            //dtgCatalogos.CellDoubleClick += DtgCatalogos_DoubleClick;
            txtBusquedaTabla.KeyPress += TxtBusquedaTabla_KeyPress;
            dtgCatalogos.CellMouseDoubleClick+= DtgCatalogos_DoubleClick;
            btnNuevo.Click += BtnNuevo_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnAgregarCampo.Click += BtnAgregarCampo_Click;
            tabControlGeneral.SelectedIndexChanged += tabControlGeneral_SelectedIndexChanged;
            btnActualizarCampos.Click += BtnActualizarCampos_Click;
            dtgLLavePrimaria.CellClick += DtgLLavePrimaria_CellClick;
            dtgBusquedaCatalogos.CellDoubleClick += DtbBusquedaCatalogos_CellDoubleClick;
            lstColumnas.SelectedValueChanged += LstColumnas_SelectedValueChanged;

            lstCampoHacerReferencia.MouseDoubleClick += LstCampoHacerReferencia_MouseDoubleClick;
            btnCopy.Click += BtnCopy_Click;
            #endregion

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
            if (!creandoNuevo)
            {
                creandoNuevo = true;
                LimpiarDatos(); 
                btnNuevo.Text = "Cancelar";
            }
            else {
                creandoNuevo = false;
                btnNuevo.Text = "Nuevo";
                ObtenerInformacionCatalogo(); 
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
                dtgCatalogos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgCatalogos.AutoGenerateColumns = false;
                dtgCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcion(txtBuscarCatalogo.Text);
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
            groupGrupos.Visible = false; 
            obtenerTipoCatalogos();
            chkPendienteCrear.Checked = chkReferenciaDesdeOtra.Checked = false;
            dtgLLavePrimaria.Rows.Clear();
            chkActivo.Checked = false;
        }
        private Catalogos catalogoPadre { get; set; }
        public void ObtenerInformacionCatalogo()
        {
            try
            {
                Catalogos catalogos = new Catalogos(); 
                catalogos.CodigoCatalogo = Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "IdCatalogo").ToString());  
                catalogos.NombreCatalogo = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "NombreCatalogo").ToString();
                catalogos.NombreFisico = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "NombreFisicoCatalogo").ToString();
                catalogos.TipoCategoria = ((TipoCategoria)cmbTipoCatalogo.SelectedItem);
                catalogos.Activo = Convert.ToBoolean(
                    UtilidadesDesktop.StringUtilities.convertirStringBool(DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "Activo").ToString())); 
                txtCodigoCatalogo.Text = catalogos.CodigoCatalogo.ToString();
                txtNombreCatalogo.Text = catalogos.NombreCatalogo;
                txtNombreFisicoCatalogo.Text = catalogos.NombreFisico;
                cmbTipoCatalogo.Enabled = false;

                catalogoGeneral = catalogos; 
                txtNombreFisicoCatalogo.Enabled = false;

                var objeto = (new DMS.Servicio.ColumnasTablaServiceImpl()).columnasTabla(catalogos);
                catalogoPadre = catalogos; 
                try
                {
                    DMS.UtilidadesDesktop.DatagridViewUtilities.llenarDatagridView(objeto, ref dtgDetalleColumnas, false);
                    ListBoxUtilities.fill(objeto, ref lstColumnas, "NameWithTechnicalCode", "CatalogoCampoId");
                    fillPrimaryKeyINfo(objeto);
                    dataGridView2.DataSource = (new Servicio.CatalogoServiceImpl()).executeQuery(StringUtilities.getSqlQuery("[" + catalogos.TipoCategoria.EsquemaFisico + "].[" + txtNombreFisicoCatalogo.Text + "]", dtgDetalleColumnas));

                }
                catch (Exception ex)
                {
                }
                groupGrupos.Visible = true; 

            }
            catch(Exception ex)
            {
                LimpiarDatos();
            }

        }

        public void obtenerInformacionCatalogosReferencias()
        {
            Catalogos catalogosLlave = new Catalogos();
            catalogosLlave.CodigoCatalogo = Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameIdCatalogo").ToString());
            catalogosLlave.NombreCatalogo = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameNombreCatalogo").ToString();
            catalogosLlave.NombreFisico = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameNombreFisicoCatalogo").ToString();

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
            UtilidadesDesktop.DatagridViewUtilities.llenarDatagridView(resultado, ref dataGridView1, false);


        }

        private void updateRelation()
        {
            if (dataGridView1.Rows.Count == 0)
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
            }
            else
                MessageBox.Show("No se puede agregar otra relación, ya cuenta con una activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ObtenerRelaciones(); 
        }

    }
}
