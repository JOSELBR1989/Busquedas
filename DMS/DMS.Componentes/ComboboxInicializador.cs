using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.Componentes
{
    public interface ComboboxInicializador
    {
        void fill();
        string selectedValueKEY { get; set; }
    }
}
