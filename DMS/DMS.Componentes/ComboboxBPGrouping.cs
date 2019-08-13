using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.Componentes
{
    public class ComboboxBPGrouping : ComboBox, ComboboxInicializador
    {
        public string selectedValueKEY
        {
            get
            {
                string result = String.Empty;
                try
                {
                    return ((DBComponents.TB002)this.SelectedItem).BU_GROUP; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                return result; 
            }

            set
            {
                bool encontrado = false;
                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (((DBComponents.TB002)this.Items[i]).BU_GROUP == value)
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

        public void fill()
        {
            this.DataSource = (new DAOComponents.Categorizacion()).bpGrouping();
            this.DisplayMember = DAOComponents.Categorizacion.bpGroupingDisplay;
            this.ValueMember = DAOComponents.Categorizacion.bpGroupingValueMember;

        }
    }
}
