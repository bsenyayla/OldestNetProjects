using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Kronus.Client.Common.Management {
    public partial class AppGeneralInfo : Forms.BaseXtraForm {
        public AppGeneralInfo() {
            InitializeComponent();
        }

        private void AppGeneralInfoForm1_Load(object sender, EventArgs e) {

            string strWorkingFolder = "";

            strWorkingFolder = "StartupPath:"                   + Application.StartupPath.ToString() + Environment.NewLine;
            strWorkingFolder += "CommonAppDataPath:"            + Application.CommonAppDataPath.ToString() + Environment.NewLine;
            strWorkingFolder += "Environment.SpecialFolder:"    + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Environment.NewLine;

            txtWorkingFolder.Text = strWorkingFolder;
        }

        private void btnDownloadApi_Click(object sender, EventArgs e) {
            try {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://www.itr.com.tr/test/Application Files/Kronus.Client.Destop_1_0_0_6/DevExpress.BonusSkins.v14.1.dll.deploy", @"C:\Users\bsenyayla\Documents\KrDevExpress.BonusSkins.v14.1.dll.deployt");
            }

            catch (Exception ee) {
                string sdfds = ee.Data.ToString();
            }
        }
    }
}
