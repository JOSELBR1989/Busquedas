using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public class ListBoxUtilities
    {
        public static void fill(List<Object> datasourse, Object objectBase, ref ListBox list)
        {
            list.DataSource = datasourse;
            list.DisplayMember = ((Modelos.IDefaultDatasource)objectBase).getDisplayName;
            list.ValueMember = ((Modelos.IDefaultDatasource)objectBase).getValueMember; 
        }
        public static void fill(List<Object> datasourse,  ref ListBox list, string displayName, string valueMember)
        {
            list.DataSource = datasourse;
            list.DisplayMember = displayName;
            list.ValueMember = valueMember;
        }
    }
}
