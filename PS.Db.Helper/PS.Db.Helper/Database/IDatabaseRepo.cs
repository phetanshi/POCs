using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Db.Helper.Database
{
    public interface IDatabaseRepo
    {
        string GetSchema(string objectName, DbObjectTypes dbObjectType = DbObjectTypes.Table);
    }
}
