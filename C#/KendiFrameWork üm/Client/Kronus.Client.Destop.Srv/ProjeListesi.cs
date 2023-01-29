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
    public partial class ProjeListesi : Common.Forms.BaseXtraForm {
        public ProjeListesi() {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            //SplashScreenManager.CloseForm();
            //return;
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e) {
            
            //SplashScreenManager.ShowForm(typeof(Common.Forms.BaseWaitForm));
            //return;
            ReportParamsProjeShortFilter rptParams = new ReportParamsProjeShortFilter();
            rptParams.Ad = txtAd.Text;
            rptParams.Kod = txtKod.Text;
            rptParams.Tipi = Common.Libs.UiTools.GetString(lkpProjeTipi.EditValue);
            rptParams.IsActive = Common.Libs.UiTools.GetBoolean(lkpDurum.EditValue, true);

            List<ProjeShort> ds = ActiveSession.Srv().GetProjeShortList(rptParams);
            gridMain.DataSource = ds;
        }

        private void FillCombos() {
            
            List<ComboItem> cList=ActiveSession.Srv().GetCombo(ComboFlowComboType.ProjeTipi,null);
            

            List<UiTools.ComboData> rcYeni = new List<UiTools.ComboData>();
            rcYeni.Add(new UiTools.ComboData { Aciklama = "Hepsi", Deger = null });
            rcYeni.AddRange(cList.Select(p => new UiTools.ComboData { Aciklama=p.Aciklama,Deger=p.Deger }));
            
            UiTools.LoadLookUp(lkpProjeTipi, rcYeni,"Hepsi..");
            UiTools.LoadLookUpFromString(lkpDurum, "Hepsi;null|Aktif;true|Pasif;false", "Hepsi");
        }

        private void ProjeListesi_Load(object sender, EventArgs e) {
            gridMain.GridDoubleClick += new EventHandler(UserControlGrid_GridDoubleClick);

            FillCombos();
        }

        protected void UserControlGrid_GridDoubleClick(object sender, EventArgs e)
        {
            ProjeShort selectedRow = gridMain.GetFocusedRow as ProjeShort;
            ProjeTanim frm = new ProjeTanim();
            frm._Id = selectedRow.Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }




    }
}
