using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronus.Client.Common.Forms
{
    public partial class BaseXtraEditForm : BaseXtraForm
    {
        public BaseXtraEditForm()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }



        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yeni();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        protected virtual void Kaydet()
        {

        }

        protected virtual void Yeni()
        {

        }

        protected virtual void Sil()
        {

        }

        public Boolean SilVisible
        {
            get
            {
                return btnSil.Visible;
            }
            set
            {
                btnSil.Visible = value;
            }
        }


    }
}
