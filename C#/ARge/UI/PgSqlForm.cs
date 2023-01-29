using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace UI
{
    public partial class PgSqlForm : Form
    {
        public PgSqlForm() {
            InitializeComponent();
        }

        private void scriptRun_Click(object sender, EventArgs e) {
            var connString = "Host=localhost;Username=postgres;Password=Abc12345;Database=dbCrm";



            var conn = new NpgsqlConnection(connString);
            conn.Open();

            // Insert some data
            using (var cmd = new NpgsqlCommand("INSERT INTO data (some_field) VALUES (@p)", conn)) {
                cmd.Parameters.AddWithValue("p", "Hello world");
                cmd.ExecuteNonQueryAsync();
            }


            //@"  SELECT *  FROM frw.""Menu""   ";
            string strSql = textBox1.Text;


            // Retrieve all rows
            NpgsqlCommand cmd_1 = new NpgsqlCommand(strSql, conn);
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd_1);
            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            

        }
    }
}
