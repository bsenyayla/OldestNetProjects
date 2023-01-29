using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronus.Client.Destop.Crm {
    public partial class SmsGonder : Common.Forms.BaseXtraForm {
        public SmsGonder() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Proxies.SrvService.SrvServiceClient ws = new Proxies.SrvService.SrvServiceClient();
            ws.SmsGonder("05355527392", "NaviMAX");
            ws.Close();

            MessageBox.Show("Gönderildi..");
        }




    }
}
