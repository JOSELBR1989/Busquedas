using DMS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public class ComboboxUtilities
    {
        public static void fillCombobox(List<Object> objetos, Object configuration, ref ComboBox combo)
        {
            try
            {
                combo.DataSource = objetos;
                combo.DisplayMember = ((IDefaultDatasource)configuration).getDisplayName;
                combo.ValueMember = ((IDefaultDatasource)configuration).getValueMember;
            }
            catch (Exception)
            {
                
            }
        }
        public static void fillCombobox(List<Object> objetos, ref ComboBox combo, string DisplayName, string ValueMember)
        {
            try
            {
                combo.DataSource = objetos;
                combo.DisplayMember = DisplayName;
                combo.ValueMember = ValueMember;
            }
            catch (Exception)
            {

            }
        }

        public static void fillComboboxSuggest(List<Object> objetos, ref ComboBox combo, string DisplayName, string ValueMember)
        {
            try
            {
                combo.AutoCompleteMode = AutoCompleteMode.Suggest;
                combo.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception)
            {

            }
        }

        public static string tagsComboboxString(params ComboBox[] combos)
        {
            StringBuilder strb = new StringBuilder();

            foreach (ComboBox item in combos)
            {
                if (strb.ToString().Length > 0)
                {
                    strb.AppendLine("," + item.Tag.ToString());
                }
                else
                    strb.AppendLine(item.Tag.ToString());
            }

            return strb.ToString();


        }

        public static bool selectedTextValidate(params ComboBox[] combos)
        {
            bool validao = true;

            foreach (ComboBox item in combos)
            {
                if (item.Text.Replace(" ","") == string.Empty)
                {
                    validao = false;
                    break; 
                }
            }

            return validao;
        }
    }
}
