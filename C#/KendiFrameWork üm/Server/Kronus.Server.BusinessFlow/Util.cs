using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kronus.Server.BusinessFlow
{
    public class Util
    {
        public static SqlConnection NewKronusCrmConnection()
        {
            //SqlConnectionStringBuilder connSb = new SqlConnectionStringBuilder("Server=bsenyayla\\dbbsenyayla;Database=dbCrm;Trusted_Connection=Yes;");
            //SqlConnectionStringBuilder connSb = new SqlConnectionStringBuilder("data source=37.148.208.40;initial catalog=dbCrm;user id=sykwebuser;password=s9y7k5;MultipleActiveResultSets=True;");
            SqlConnectionStringBuilder connSb = new SqlConnectionStringBuilder("data source=.;initial catalog=dbCrm;integrated security=True;MultipleActiveResultSets=True;");
                                                                                

             
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            connSb.Pooling = true;
            connSb.MaxPoolSize = 5;
            connSb.MinPoolSize = 3;
            connSb.ConnectTimeout = 99999;
            connSb.MultipleActiveResultSets = true;

            return new SqlConnection(connSb.ConnectionString);
        }

        public static DataSet ExecuteDataSetQuery(string Query, SqlConnection Connection, List<SqlParameter> Parameters)
        {
            SqlCommand com = new SqlCommand(Query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.SelectCommand.CommandTimeout = int.MaxValue;
            if (Query.ToLower().StartsWith("Sp"))
            {
                com.CommandType = CommandType.StoredProcedure;
            }

            if (Parameters != null)
            {
                foreach (var sqlParameter in Parameters)
                {
                    com.Parameters.Add(sqlParameter);
                }
            }

            Connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            Connection.Close();

            return ds;
        }

        public static bool ExecuteCommand(SqlCommand cmd)
        {
            SqlConnection conn = NewKronusCrmConnection();

            cmd.Connection = conn;

            using (conn)
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {

                    return false;
                }
            }
        }

        public static SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            SqlConnection conn = NewKronusCrmConnection();

            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }

        public static bool UpdateDB(string table, DataTable dataTable)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM @Table", NewKronusCrmConnection());

            da.SelectCommand.Parameters.AddWithValue("@Table", table);

            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            scb.ConflictOption = ConflictOption.OverwriteChanges;

            try
            {
                da.Update(dataTable);
                return true;
            }
            catch
            {

                return false;
            }

        }
    }
}