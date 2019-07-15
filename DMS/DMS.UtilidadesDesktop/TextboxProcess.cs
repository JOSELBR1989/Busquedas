using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public static class TextboxProcess
    {
        public static bool PressEnter(KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                return true;
            else
                return false; 
        }
        public static bool pressCharOrDigit(KeyPressEventArgs e) {
            if (char.IsLetterOrDigit(e.KeyChar))
                return false;
            else if (char.IsControl(e.KeyChar))
                return false;
            else
                return true;
        }

        public static bool isNumber(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                return false;
            else if (char.IsControl(e.KeyChar))
                return false;
            else
                return true;
        }

        public static bool validarRequeridos(params TextBox[] validador)
        {
            bool resultado = true;

            foreach (TextBox item in validador)
            {
                if (item.Text.Replace(" ", "").Length == 0)
                {
                    resultado = false;
                    break; 
                }
            }
            
            return resultado; 
        }

        public static string tagsTextBoxString(params TextBox[] textbox)
        {
            StringBuilder strb = new StringBuilder();

            foreach (TextBox item in textbox)
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

    }
}
