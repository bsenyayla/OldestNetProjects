using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace UI
{
    public partial class ExceptionFrm : Form
    {
        public ExceptionFrm() {
            InitializeComponent();
        }

        private void btnException_Click(object sender, EventArgs e) {
            
                int b = 10, c = 0;
                int a = b / c;
            


        }

        private void btnPgSql_Click(object sender, EventArgs e) {
            new PgSqlForm().Show();
        }
    }
}
