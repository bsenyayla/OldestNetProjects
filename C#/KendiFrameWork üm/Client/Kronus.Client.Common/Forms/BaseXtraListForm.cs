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
    public partial class BaseXtraListForm : BaseXtraForm
    {
        public BaseXtraListForm()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }
        
        // Derived Forms MUST override this method
        protected virtual void Yenile()
        {
            // Code logic in derived Form
        }
        
    }
}
