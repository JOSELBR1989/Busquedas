using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Modelos
{
    public interface IDefaultDatasource
    {
        string getDisplayName { get; }
        string getValueMember { get; }
    }
}
