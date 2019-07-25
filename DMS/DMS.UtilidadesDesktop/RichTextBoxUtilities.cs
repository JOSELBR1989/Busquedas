using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public class RichTextBoxUtilities
    {
        public static void Pintar(string cadena, string[] palabrasreservadas, ref RichTextBox richTextBox1)
        {
            int selectionStart = richTextBox1.SelectionStart; 

            for (int i = 0; i < palabrasreservadas.Length; i++)
            {
                int Inicio = richTextBox1.Find(palabrasreservadas[i]);
                int Final = richTextBox1.Text.LastIndexOf(palabrasreservadas[i]);
                if ((Inicio >= 0) && (Final >= 0))
                {
                    richTextBox1.SelectionStart = Final;
                    richTextBox1.SelectionLength = palabrasreservadas[i].Length;
                    richTextBox1.SelectionColor = Color.Blue;
                }
                else
                {
                    int final = richTextBox1.Text.LastIndexOf("//");
                    if ((richTextBox1.Find("//") >= 0) && (final >= 0))
                    {
                        richTextBox1.SelectionColor = Color.Green;

                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Black;
                    }
                }
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.SelectionColor = Color.Black;

            }

            richTextBox1.SelectionStart = selectionStart; 
        }
    }
}
