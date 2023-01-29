using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateApp {
    public partial class BaseForm : Form {
        public delegate void SetTextDelegaHander();
        
        public BaseForm() {
            InitializeComponent();
            SetTextDelegaHander delege = new SetTextDelegaHander(XXX);
            delege.Invoke();
        }

        private void btnButon_1_Click(object sender, EventArgs e) {
            //MessageBox.Show(this.Text);
        }

        private void btnEvent(object sender, EventArgs e) {
            MessageBox.Show("btn evetn");
        }

        public void XXX() {
            MessageBox.Show("d");
        }
    }
}
