using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Db.Helper.Database
{
    public enum DbObjectTypes
    {
        None = 0,
        Table,
        StoredProcedure,
        UserDefinedFunction,
        Trigger
    }
}
