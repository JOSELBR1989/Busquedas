using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public class DatagridViewUtilities
    {
        public static object ObtenerValorCeldaActual(DataGridView dt, string columnName)
        {
            int rowIndex = dt.CurrentCell.RowIndex;
            try
            { 
                return dt.Rows[rowIndex].Cells[columnName].Value.ToString();
            }
            catch {
                return String.Empty; 
            }
        }

        public static void llenarDatagridView(List<Object> objetos, ref DataGridView dtg, bool autogenerateColumns)
        {
            dtg.AutoGenerateColumns = autogenerateColumns;
            dtg.DataSource = objetos;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
        }
        public static void llenarDatagridViewDinamico(List<Object> objetos, ref DataGridView dtg)
        {
            dtg.DataSource = objetos;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
