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
    public partial class GuzergahTanim : Common.Forms.BaseXtraForm
    {
        public Guid? _Id = null;
        public Guid? _GuzergahMainId =null;
        FormOperation fnFormOperation = new FormOperation();

        public GuzergahTanim()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillCombos()
        {
            List<ComboItem> cSoforList = ActiveSession.Srv().Sofor_GetCombo();
            List<ComboItem> cHostesList = ActiveSession.Srv().Hostes_GetCombo();
            List<ComboItem> cAracList = ActiveSession.Srv().Arac_GetCombo();

            List<UiTools.ComboData> rcSoforList = new List<UiTools.ComboData>();
            List<UiTools.ComboData> rcHostesList = new List<UiTools.ComboData>();
            List<UiTools.ComboData> rcAracList = new List<UiTools.ComboData>();

            rcSoforList.AddRange(cSoforList.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }));
            rcHostesList.AddRange(cHostesList.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }));
            rcAracList.AddRange(cAracList.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }));

            UiTools.LoadLookUp(edt_Sofor, rcSoforList, "");
            UiTools.LoadLookUp(edt_Hostes, rcHostesList, "");
            UiTools.LoadLookUp(edt_Arac, rcAracList, "");
        }

        private void FillForm()
        {
            GuzergahS ds = ActiveSession.Srv().GetGuzergahById(_Id.Value);
            if (ds == null) { return; }
            edt_ProjeAdi.EditValue = ds.ProjeAd;
            edt_AnaGuzergahAd.EditValue = ds.GuzergahMainAd;
            edt_Ad.EditValue = ds.Ad;
            edt_Kod.EditValue = ds.Kod;
            edt_KisiSayisi.EditValue = ds.KisiSayisi;
            edt_Hostes.EditValue = Common.Libs.UiTools.GetString(ds.HostesId);
            edt_Sofor.EditValue = Common.Libs.UiTools.GetString(ds.SoforId);
            edt_Arac.EditValue = Common.Libs.UiTools.GetString(ds.AracId);
            _GuzergahMainId = ds.GuzergahMainId;
            cbcIsActive.EditValue = ds.IsActive.Value;
        }

        private void SaveForm() {
            SrvGuzergah nwGuzergah=new SrvGuzergah();
            nwGuzergah.Ad = UiTools.GetString(edt_Ad.EditValue);
            nwGuzergah.Arac = UiTools.GetInt32(edt_Arac.EditValue);
            nwGuzergah.Hostes = UiTools.GetLookUpEditValue(edt_Hostes).Value;
            nwGuzergah.IsActive = cbcIsActive.Checked;
            nwGuzergah.KisiSayisi = UiTools.GetInt32(edt_KisiSayisi.EditValue, true);
            nwGuzergah.Kod = UiTools.GetString(edt_Kod.EditValue);
            nwGuzergah.Sofor = UiTools.GetLookUpEditValue(edt_Sofor).Value;
            nwGuzergah.GuzergahMainId = _GuzergahMainId.Value;

            if (_Id == null) {
                ActiveSession.Srv().AddGuzergah(nwGuzergah);
            }
            else
            {
                nwGuzergah.Id = _Id.Value;
                ActiveSession.Srv().EditGuzergah(nwGuzergah);
            }
        }

        private void GuzergahTanim_Load(object sender, EventArgs e)
        {
            FillCombos();
            if (_Id != null)
            {
                FillForm();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void GuzergahTanim_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            fnFormOperation.CleanForm(this);
            _Id = null;
        }
    }
}
