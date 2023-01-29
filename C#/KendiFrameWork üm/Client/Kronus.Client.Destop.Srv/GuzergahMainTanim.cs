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

namespace Kronus.Client.Destop.Srv
{
    public partial class GuzergahMainTanim : Common.Forms.BaseXtraForm
    {
        public Guid? _Id = null;
        bool _onLoad = false;
        FormOperation fnFormOperation = new FormOperation();

        public GuzergahMainTanim()
        {
            InitializeComponent();
            gridMain.GridDoubleClick += new EventHandler(gridMain_GridDoubleClick);
        }

        protected void gridMain_GridDoubleClick(object sender, EventArgs e)
        {
            GuzergahShort row = gridMain.GetFocusedRow as GuzergahShort;
            if (row == null) { return; }

            GuzergahTanim frm = new GuzergahTanim();
            frm._Id = row.Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillCombos()
        {
            List<ComboItem> cProjeList = ActiveSession.Srv().GetProjeListForCombo();

            List<UiTools.ComboData> rcProjeList = new List<UiTools.ComboData>();
            rcProjeList.AddRange(cProjeList.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }));
            UiTools.LoadLookUp(edt_lkpProje, rcProjeList, "");
        }

        private void FillForm()
        {
            GuzergahMainS ds = ActiveSession.Srv().GetGuzergahMainById(_Id.Value);
            ReportParamsGuzergahShortFilter rptParam = new ReportParamsGuzergahShortFilter();
            rptParam.IsActive = true;
            rptParam.GuzergahMainId = _Id;

            List<GuzergahShort> rcGuzergahList = ActiveSession.Srv().GetGuzergahList(rptParam);
           
            if (ds == null) { return; }
            edt_Ad.EditValue = Common.Libs.UiTools.GetString(ds.Ad);
            edt_Km.EditValue = Common.Libs.UiTools.GetDouble(ds.Km);
            edt_Kod.EditValue = Common.Libs.UiTools.GetString(ds.Kod);
            edt_lkpProje.EditValue = Common.Libs.UiTools.GetString(ds.ProjeId);
            edt_MusteriFiyat.EditValue = Common.Libs.UiTools.GetDouble(ds.MusteriFiyat);
            edt_TedarikciFiyat.EditValue = Common.Libs.UiTools.GetDouble(ds.TedarikFiyat);
            _Id = ds.Id;
            cbcIsActive.Checked = ds.IsActive.Value;
            gridMain.DataSource = rcGuzergahList;
        }

        private void GuzergahMainTanim_Load(object sender, EventArgs e)
        {
            if (_onLoad == true) { return; }
            _onLoad = true;
            FillCombos();

            if (_Id != null)
            {
                FillForm();
            }
        }

        private void Kaydet()
        {
            SrvGuzergahMain nwRow = new SrvGuzergahMain();
            nwRow.Ad = UiTools.GetString(edt_Ad.EditValue);
            nwRow.IsActive = cbcIsActive.Checked;
            nwRow.IsDeleted = false;
            nwRow.Km = UiTools.GetInt32(edt_Km.EditValue, true);
            nwRow.Kod = UiTools.GetString(edt_Kod.EditValue);
            nwRow.MusteriFiyat = UiTools.GetDecimal(edt_MusteriFiyat.EditValue, true);
            nwRow.ProjeId = UiTools.GetLookUpEditValue(edt_lkpProje).Value;
            nwRow.TedarikFiyat = UiTools.GetDecimal(edt_TedarikciFiyat.EditValue, true);
            
            string msg = "";
            
            if (_Id != null)
            {
                nwRow.Id = _Id.Value;
                ActiveSession.Srv().EditGuzergahMain(nwRow);
                msg = "edit ok";
            }
            else
            {
                ActiveSession.Srv().AddGuzergahMain(nwRow);
                msg = "insert ok";
            }
            

            MessageBox.Show(msg, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            fnFormOperation.CleanForm(this);
            _Id = null;
            gridMain.DataSource = null;

        }

        private void btnYeniGuzergah_Click(object sender, EventArgs e)
        {
            GuzergahTanim frm = new GuzergahTanim();
            frm._GuzergahMainId = _Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void GuzergahMainTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}