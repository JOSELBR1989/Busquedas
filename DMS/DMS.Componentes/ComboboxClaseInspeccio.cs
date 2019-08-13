using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.Componentes
{
    public class ComboboxClaseInspeccio : ComboBox, ComboboxInicializador
    {

        public void fill()
        {
            this.DataSource = (new DAOComponents.Categorizacion()).catalogosInspeccion();
            this.DisplayMember = DAOComponents.Categorizacion.catalogosInspeccionDisplay;
            this.ValueMember = DAOComponents.Categorizacion.catalogosInspeccionValueMember;
        }

        public string selectedValueKEY
        {
            get {
                string result = "";
                try
                {
                    return ((DBComponents.RQSKT)this.SelectedItem).KATALOGART;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                return result;

            }
            set {
                bool encontrado = false; 
                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (((DBComponents.RQSKT)this.Items[i]).KATALOGART == value)
                    {
                        this.SelectedIndex = i;
                        encontrado = true; 
                        break;
                    }
                }
                
                if (encontrado == false)
                    this.SelectedItem = null;
            }
        }

        
    }
}
