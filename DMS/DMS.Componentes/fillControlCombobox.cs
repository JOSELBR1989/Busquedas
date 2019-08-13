using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.Componentes
{
    public static class fillControlCombobox
    {
        public static void FillControls(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is ComboBox)
                {
                    try
                    {
                        ((ComboboxInicializador)item).fill();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
}
