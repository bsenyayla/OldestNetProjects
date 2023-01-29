using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kronus.Server.BusinessFlow;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List < Kronus.Server.Entity.Models.ComboItem > sd= Kronus.Server.BusinessFlow.Crm.DepartmanBusinessFlow.GetDepartmanListForCombo();

            string sfd = "";

        }
    }
}
