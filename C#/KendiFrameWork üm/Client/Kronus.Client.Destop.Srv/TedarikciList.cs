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

namespace Kronus.Client.Destop.Srv
{
    public partial class TedarikciList : Common.Forms.BaseXtraForm
    {
        public TedarikciList() {
            InitializeComponent();
            gridMain.GridDoubleClick += new EventHandler(UserControlGrid_GridDoubleClick);
        }

        protected void UserControlGrid_GridDoubleClick(object sender, EventArgs e) {
            TedarikciShort selectedRow = gridMain.GetFocusedRow as TedarikciShort;
            if (selectedRow == null) return;

            TedarikciTanim frm = new TedarikciTanim();
            frm._Id = selectedRow.Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e) {
            ReportParamsTedarikciShortFilter rptParams = new ReportParamsTedarikciShortFilter();
            rptParams.CariAd = txtCariAd.Text;
            rptParams.YetkiliKisi = txtYetkiliKisi.Text;
            rptParams.IsActive = Common.Libs.UiTools.GetBoolean(lkpDurum.EditValue, true);
            gridMain.DataSource = ActiveSession.Srv().GetTedarikciList(rptParams);
        }

        private void FillCombos() {
            UiTools.LoadLookUpFromString(lkpDurum, "Hepsi;null|Aktif;true|Pasif;false", "Hepsi");
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TedarikciList_Load(object sender, EventArgs e) {
            FillCombos();
        }

        private void labelControl3_Click(object sender, EventArgs e) {

        }

        private void lkpDurum_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
