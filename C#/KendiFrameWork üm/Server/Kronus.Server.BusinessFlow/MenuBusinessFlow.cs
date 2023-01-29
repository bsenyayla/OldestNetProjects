using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Kronus.Server.BusinessFlow
{
    public class MenuBusinessFlow
    {
        public static DataSet GetMenu(string vlDomainName)
        {
            string SQLquery = " exec Sp_FwUtil @TranType=1 ,@DomainName='" + vlDomainName + "' ";
            DataSet ds = new DataSet("MenuDataSet");
            SqlDataAdapter myAdapter = new SqlDataAdapter(SQLquery, Util.NewKronusCrmConnection());
            myAdapter.Fill(ds, "MenuTable");
            return ds;
        }
    }
}
