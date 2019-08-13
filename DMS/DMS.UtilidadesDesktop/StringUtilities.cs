using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UtilidadesDesktop
{
    public class StringUtilities
    {
        public static bool convertirStringBool(string valor)
        {
            if (valor == "X" || valor == "SI" || valor == "S")
            {
                return true;
            }
            else
                return false; 
        }
        public static Object getValueOfObject(Object myObject, string ObjectName)
        {
            Type myType = myObject.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            Object resultado = new object(); 
            foreach (PropertyInfo prop in props)
            {
                if(prop.Name == ObjectName)
                    resultado = prop.GetValue(myObject, null);
                // Do something with propValue
            }


            return resultado; 
        }


        public static string getSqlQuery(string tableName, DataGridView dtg)
        {
            return getQueryExecuted(tableName, dtg);
        }
        public static string getSqlQuery(string tableName, DataGridView dtg,decimal percent)
        {
            return getQueryExecuted(tableName, dtg,percent);
        }

        private static string getQueryExecuted(string tableName, DataGridView dtg)
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("SELECT ");

            for (int i = 0; i < dtg.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtg.Rows[i].Cells["dtActivo"].Value))
                {
                    if (i > 0)
                    {
                        strb.AppendLine(",[" + dtg.Rows[i].Cells["NombreTecnico"].Value.ToString() + "] ");
                    }
                    else
                    {
                        strb.AppendLine("[" + dtg.Rows[i].Cells["NombreTecnico"].Value.ToString() + "] ");
                    }

                }
            }


            strb.AppendLine("FROM [DB_DMs]." + tableName);


            return strb.ToString();
        }

        private static string getQueryExecuted(string tableName, DataGridView dtg, decimal percent)
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("SELECT TOP " + percent + " PERCENT");

            for (int i = 0; i < dtg.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtg.Rows[i].Cells["dtActivo"].Value))
                {
                    if (i > 0)
                    {
                        strb.AppendLine(",[" + dtg.Rows[i].Cells["NombreTecnico"].Value.ToString() + "] ");
                    }
                    else
                    {
                        strb.AppendLine("[" + dtg.Rows[i].Cells["NombreTecnico"].Value.ToString() + "] ");
                    }

                }
            }


            strb.AppendLine("FROM [DB_DMs]." + tableName);


            return strb.ToString();
        }


    }
}
