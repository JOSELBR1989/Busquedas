using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAOComponents
{
    public class Categorizacion
    {
        private static DMS.DBComponents.DB_DMComponentsEntities db;
        public Categorizacion()
        {
            db = new DBComponents.DB_DMComponentsEntities();
        }

        #region "Catalogo de métodos de inspeccion"
        public List<Object> catalogosInspeccion()
        {
            List<Object> resultado =  new List<DBComponents.RQSKT>().Cast<Object>().ToList();

            try
            {
                resultado = (from da in db.RQSKT
                             select da).ToList().Cast<Object>().ToList();
            }
            catch (Exception ex)
            {
                resultado = new List<DBComponents.RQSKT>().Cast<Object>().ToList();
            }


            return resultado;
        }
        public static string catalogosInspeccionDisplay {
            get { return "KATALOGTXT"; }
        }
        public static string catalogosInspeccionValueMember {
            get { return "KATALOGART"; }
        }

        #endregion

        #region "CATALOGO BP GROUPING"
        public List<Object> bpGrouping()
        {
            List<Object> resultado = (new List<DBComponents.TB002>()).Cast<Object>().ToList();
            try
            {
                resultado = (from da in db.TB002
                             select da).ToList().Cast<Object>().ToList();
            }
            catch (Exception ex)
            {
                resultado = (new List<DBComponents.TB002>()).Cast<Object>().ToList();
            }

            return resultado; 
        }
        public static string bpGroupingDisplay {
            get { return "TXT40"; }
        }
        public static string bpGroupingValueMember {
            get { return "BU_GROUP"; }
        }

        #endregion
    }
}
