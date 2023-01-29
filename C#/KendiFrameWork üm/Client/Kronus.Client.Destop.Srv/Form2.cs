using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kronus.Client.Proxies;
using Kronus.Client.Proxies.SrvService;
using Kronus.Client.Common.Libs;
using DevExpress.XtraSplashScreen;

namespace Kronus.Client.Destop.Srv {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e) {
            ucBasicGrid1.GridDoubleClick += new EventHandler(UserControlGrid_GridDoubleClick);
                

            ReportParamsProjeShortFilter rptParams = new ReportParamsProjeShortFilter();
            rptParams.Ad    = "";
            rptParams.Kod   = "";
            rptParams.Tipi  = "";
            rptParams.IsActive = null;

            Proxies.SrvService.SrvServiceClient ws = new SrvServiceClient();
            List<ProjeShort> ds = ws.GetProjeShortList(rptParams);
            ws.Close();


            ucBasicGrid1.DataSource = ds;
            gridControl1.DataSource = ds;
        }

        protected void UserControlGrid_GridDoubleClick(object sender, EventArgs e)
        {
            Kronus.Client.Proxies.SrvService.ProjeShort rww = ucBasicGrid1.GetFocusedRow as Kronus.Client.Proxies.SrvService.ProjeShort;
            

            MessageBox.Show(rww.Ad.ToString() + " -->  gelen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("help req");
        }

        private void Form2_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("help click");
        }
    }
}
