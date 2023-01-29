using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            StructC vl = new StructC();
            vl.ad[0] = 'd';
            vl.SetSinif = 3;
            string TTT=vl.GetName();

        }
    }
}
