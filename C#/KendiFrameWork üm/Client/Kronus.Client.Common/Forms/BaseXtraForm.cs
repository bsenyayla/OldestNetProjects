using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kronus.Client.Common.Forms
{
    public partial class BaseXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseXtraForm()
        {
            InitializeComponent();
        }

        private void BaseXtraForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("HelpRequested");
        }
    }
}