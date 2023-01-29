using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronus.Client.Destop.Srv
{
    public partial class TestFormEdit : Kronus.Client.Common.Forms.BaseXtraEditForm
    {
        public TestFormEdit()
        {
            InitializeComponent();
            SilVisible = false;
        }

        protected override void Kaydet()
        {
            MessageBox.Show("Kaydet");
        }

        protected override void Yeni()
        {
            MessageBox.Show("Yeni");
        }

        protected override void Sil()
        {
            MessageBox.Show("Sil");
        }
    }
}
