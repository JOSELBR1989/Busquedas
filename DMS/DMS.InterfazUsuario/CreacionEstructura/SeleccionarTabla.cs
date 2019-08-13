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
    public partial class SeleccionarTabla : Form
    {

        private Catalogos catalogoPadreFK; 
        public SeleccionarTabla()
        {
            InitializeComponent();

            DMS.UtilidadesDesktop.ListBoxUtilities.fill(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref lstCategorias);

            for (int i = 0; i < lstCategorias.Items.Count; i++)
                lstCategorias.SetSelected(i, true);

            obtenerCatalogos(); 
            txtBuscarCatalogo.KeyPress += TxtBuscarCatalogo_KeyPress;
            dtgCatalogos.CellDoubleClick += DtgCatalogos_CellDoubleClick;
            lstCategorias.SelectedIndexChanged += LstCategorias_SelectedIndexChanged;
        }
        public SeleccionarTabla(Modelos.Catalogos catalogoPadre)
        {
            InitializeComponent();
            catalogoPadreFK = new Catalogos();
            catalogoPadreFK = catalogoPadre;

            DMS.UtilidadesDesktop.ListBoxUtilities.fill(((new DMS.Servicio.TipoCategoriaServiceImpl()).tiposCategoria()).Cast<Object>().ToList(), (new Modelos.TipoCategoria()), ref lstCategorias);

            for (int i = 0; i < lstCategorias.Items.Count; i++)
                lstCategorias.SetSelected(i, true);

            obtenerCatalogos();
            txtBuscarCatalogo.KeyPress += TxtBuscarCatalogo_KeyPress;
            dtgCatalogos.CellDoubleClick += DtgCatalogos_CellDoubleClick;
            lstCategorias.SelectedIndexChanged += LstCategorias_SelectedIndexChanged;
        }

        private void LstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerCatalogos(); 
        }

        private void DtgCatalogos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea seleccionar el catalogo para relacionarlo??", "Desea seleccioanr?", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                //UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "IdCatalogo").ToString()

                try
                {
                    (new Servicio.CatalogoRelacionesServicieImpl()).agregarRelacion(Convert.ToInt64(UtilidadesDesktop.DatagridViewUtilities.ObtenerValorCeldaActual(dtgCatalogos, "IdCatalogo").ToString()),
                        catalogoPadreFK.CodigoCatalogo);
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    UtilidadesDesktop.MessageBoxUtilities.errorAlmacenarRegistros(ex);
                }

            }

        }

        private void TxtBuscarCatalogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (UtilidadesDesktop.TextboxProcess.PressEnter(e))
                obtenerCatalogos();
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
                dtgCatalogos.DataSource = (new DMS.Servicio.CatalogoServiceImpl()).busquedaPorDescripcion(txtBuscarCatalogo.Text, result.ToArray(), true);
            }
            catch
            {
            }
        }
    }
}
