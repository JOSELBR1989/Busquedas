using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public class MessageBoxUtilities
    {
        public static DialogResult mensajePreguntaGuardar(string catalogo)
        {
            string mensaje = "Desea guardar la información del " + catalogo + " modificado?";
            return MessageBox.Show(mensaje, "Actualizar información?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult mensajePreguntaBorrar(string catalogo)
        {
            string mensaje = "Desea eliminar el registro seleccionado del catalogo: " + catalogo + "?";
            return MessageBox.Show(mensaje, "Actualizar información?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void registroAlmacenadoCorrectamente()
        {
            MessageBox.Show("Registros almacenados de forma correcta", "Almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void errorAlmacenarRegistros(Exception ex)
        {
            string mensaje = String.Empty;

            try
            {
                mensaje = ex.InnerException.Message.ToString();
            }
            catch
            {
                mensaje = ex.Message.ToString();
            }

            MessageBox.Show("Registro no se pudo almacenar, error: " + mensaje, "Almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void camposIncompletos(string Objetos)
        {

            MessageBox.Show("Error: los campos no están completos, favor verificar.\n Campos a validar: " +  Objetos, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
    }
}
