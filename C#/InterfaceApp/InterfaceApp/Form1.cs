using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAbstract_Click(object sender, EventArgs e) {
            Abstract_.dbAbstract _db = new Abstract_.dbBase();

            _db.Run();
        }


        public DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(int));


            table.Rows.Add("A birimi", 0);
            table.Rows.Add("B birimi", 33);
            table.Rows.Add("C birimi", 20);
            table.Rows.Add("D birimi", 80);
            table.Rows.Add("E birimi", 50);
            table.Rows.Add("E birimi", 100);
            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartControl2.SeriesDataMember = "Value";
            chartControl2.SeriesTemplate.ArgumentDataMember = "Argument";
            chartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            chartControl2.DataSource = this.GetTable();
        }
    }
}
