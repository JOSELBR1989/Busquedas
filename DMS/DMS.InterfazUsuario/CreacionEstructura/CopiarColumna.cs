using DMS.Modelos;
using DMS.UtilidadesDesktop;
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
    public partial class CopiarColumna : Form
    {
        public CopiarColumna()
        {
            InitializeComponent();
            txtBusquedaTabla.KeyPress += TxtBusquedaTabla_KeyPress;
            dtgBusquedaCatalogos.CellDoubleClick += DtgBusquedaCatalogos_CellDoubleClick;

        }


        public Catalogos CatalogoBase { get; set; }

        public CopiarColumna(Catalogos catalogoBase)
        {
            InitializeComponent();
            catalogoBase = new Catalogos();
            CatalogoBase = catalogoBase; 
            txtBusquedaTabla.KeyPress += TxtBusquedaTabla_KeyPress;
            dtgBusquedaCatalogos.CellDoubleClick += DtgBusquedaCatalogos_CellDoubleClick;
            btnSeleccionar.Click += BtnSeleccionar_Click;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (lstCampoHacerReferencia.Items.Count > 0)
            {
                var selectedItem = lstCampoHacerReferencia.SelectedItem;
                long CatalogoCampoId = (long)UtilidadesDesktop.StringUtilities.getValueOfObject(selectedItem, "CatalogoCampoId");
                
                Modelos.CamposCatalogo cat = new Modelos.CamposCatalogo();
                cat.CodigoCampoCatalogo = CatalogoCampoId;
                var valor = (new Servicio.ColumnasTablaServiceImpl()).obtenePorId(cat);

                valor.Catalogo = CatalogoBase;
                try
                {
                    (new Servicio.ColumnasTablaServiceImpl()).nuevo(valor);
                    this.Close();
                }
                catch (Exception ex)
                {
                }

            }
        }

        private void DtgBusquedaCatalogos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        public void obtenerInformacionCatalogosReferencias()
        {
            Catalogos catalogosLlave = new Catalogos();
            catalogosLlave.CodigoCatalogo = Convert.ToInt64(DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameIdCatalogo").ToString());
            catalogosLlave.NombreCatalogo = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameNombreCatalogo").ToString();
            catalogosLlave.NombreFisico = DMS.UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, "dtNameNombreFisicoCatalogo").ToString();

            var result = (new Servicio.ColumnasTablaServiceImpl()).columnasTablaPK(catalogosLlave);
            ListBoxUtilities.fill(result, ref lstCampoHacerReferencia, "NameWithTechnicalCode", "CatalogoCampoId");


            //CamposCatalogo camposCatalogoPK = new CamposCatalogo();
            //UtilidadesDesktop.StringUtilities.getValueOfObject(lstCampoHacerReferencia, "CatalogoCampoId");

            //UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgBusquedaCatalogos, ""); 

        }


    }
}
