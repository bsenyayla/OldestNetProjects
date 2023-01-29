using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;

namespace Arch.SmartClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST = dpsms8.digiturk.local)(PORT = 1527))(CONNECT_DATA=(SID = MAINTENANCE_TEST)));User Id=DT_APPLICATION_USR;Password=DT_APPLICATION_USR;Pooling=true;Statement Cache Size=10";

            OracleConnection conn = new OracleConnection(oradb); // C#

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = @"select party_role_account_spec_cd 
                                from dt_party_dba.party_role_account
                                where rownum< 3";

            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            label1.Text = dr.GetString(0);

            conn.Dispose();
        }
    }
}
