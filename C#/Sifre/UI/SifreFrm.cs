using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SifreFrm : Form
    {
        private static string pass = "+Tur41!";
        public SifreFrm() {
            InitializeComponent();
        }

        private void btnMd_Click(object sender, EventArgs e) {
            txtCozulmus.Text = string.Empty;
            txtSifrelenmis.Text = string.Empty;

            string str = txtPure.Text;
            txtCozulmus.Text = Cipher.Decrypt(str, pass);
            txtSifrelenmis.Text = Cipher.Encrypt(str, pass);
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
