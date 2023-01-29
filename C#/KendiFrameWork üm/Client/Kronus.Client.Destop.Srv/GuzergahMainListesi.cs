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
    public partial class GuzergahMainListesi : Common.Forms.BaseXtraForm
    {
        bool _onLoad = false;

        public GuzergahMainListesi()
        {
            InitializeComponent();
            gridMain.GridDoubleClick += new EventHandler(gridMain_GridDoubleClick);
        }

        private void FillCombos()
        {
            List<ComboItem> cProjeList = ActiveSession.Srv().GetProjeListForCombo();
            List<ComboItem> cProjeTipi = ActiveSession.Srv().GetCombo(ComboFlowComboType.ProjeTipi,null);

            List<UiTools.ComboData> rcProjeList = new List<UiTools.ComboData>();
            rcProjeList.Add(new UiTools.ComboData { Aciklama = "Hepsi", Deger = null });
            rcProjeList.AddRange(cProjeList.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }));

            UiTools.LoadLookUp(edt_lkpProje, rcProjeList, "Hepsi");
            UiTools.LoadLookUpFromString(lkpDurum, "Hepsi;null|Aktif;true|Pasif;false", "Hepsi");

            List<UiTools.ComboData> rcProjeTipList = new List<UiTools.ComboData>();
            rcProjeTipList.Add(new UiTools.ComboData { Aciklama = "Hepsi", Deger = "" });
            rcProjeTipList.AddRange(cProjeTipi.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }));

            UiTools.LoadLookUp(edt_lkpTip, rcProjeTipList, "Hepsi");
        }

        private void FillGrid()
        {
            ReportParamsGuzergahMainShortFilter rptParams = new ReportParamsGuzergahMainShortFilter();
            rptParams.IsActive  = Common.Libs.UiTools.GetBoolean(lkpDurum.EditValue, true);
            rptParams.ProjeId   = Common.Libs.UiTools.GetLookUpEditValue(edt_lkpProje);
            rptParams.ProjeTipi = UiTools.GetString(edt_lkpTip.EditValue);

            List<GuzergahMainShort> ds = ActiveSession.Srv().GetGuzergahMainList(rptParams);
            
            gridMain.DataSource = ds;
        }

        private void GuzergahMainListesi_Layout(object sender, LayoutEventArgs e)
        {
            if (_onLoad == true) {
                return;
            }
            _onLoad = true;
            FillCombos();
        }

        protected void gridMain_GridDoubleClick(object sender, EventArgs e)
        {
            GuzergahMainShort row = gridMain.GetFocusedRow as GuzergahMainShort;
            if (row == null) { return; }

            GuzergahMainTanim frm = new GuzergahMainTanim();
            frm._Id = row.Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void GuzergahMainListesi_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Load olayı");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnYeniGuzergahMain_Click(object sender, EventArgs e)
        {
            GuzergahMainTanim frm = new GuzergahMainTanim();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
