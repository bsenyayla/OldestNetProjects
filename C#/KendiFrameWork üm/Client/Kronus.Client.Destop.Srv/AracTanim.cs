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
    public partial class AracTanim : Common.Forms.BaseXtraForm
    {
        public int? _Id = null;
        bool isFormLoad = false;
        List<ComboItem> cTedarikci = new List<ComboItem>();
        List<ComboItem> cRenk = new List<ComboItem>();

        public AracTanim() {
            InitializeComponent();
        }

        private void FillForm() {
            AracS ds = ActiveSession.Srv().Arac_GetAracById(_Id.Value);
            if (ds == null) { return; }
            edt_Plaka.EditValue             = ds.Plaka;
            edt_Id.EditValue                = ds.Id;
            cbcIsActive.EditValue           = ds.IsActive;
            edt_LogoKod.EditValue           = ds.LogoKodu.Trim();
            edt_Marka.EditValue             = UiTools.GetString(ds.Marka);
            edt_RTipi.EditValue             = UiTools.GetString(ds.Tipi);
            edt_ModelYili.EditValue         = ds.ModelYili;
            edt_lkpRenk.EditValue           = UiTools.GetString(ds.Renk);
            edt_lkpsTedarikci.EditValue     = (ds.TedarikciId == null ? null : ds.TedarikciId.Value.ToString());
            edt_YolcuKapasitesi.EditValue   = ds.YolcuKapasitesi;


            edt_RAracSahibiAd.EditValue     = ds.AracSahibiAd;
            edt_RAracSahibiSoyad.EditValue  = ds.AracSahibiSoyad;
            edt_RCinsi.EditValue            = UiTools.GetString(ds.Cinsi);
            edt_RIstiapHaddi.EditValue      = ds.IstiapHaddi;
            edt_RMotorGucu.EditValue        = ds.MotorGucu;
            edt_RMotorNo.EditValue          = ds.MotorNo;
            edt_RMuayeneTarihi.Value        = (ds.MuayeneTarihi!=null ? ds.MuayeneTarihi.Value : DateTime.Now);
            edt_RNetAgirlik.EditValue       = ds.NetAgirlik;
            edt_RSasiNo.EditValue           = ds.SasiNo;
            edt_RSilindirHacmi.EditValue    = ds.SilindirHacmi;
            
        }

        private void FillCombo() {
            cTedarikci.Add(new ComboItem { Aciklama = "Öz Mal", Deger = null });
            cTedarikci.AddRange(ActiveSession.Srv().GetCombo(ComboFlowComboType.Tedarikci,null));
            cRenk = ActiveSession.Srv().GetCombo(ComboFlowComboType.Renk,null);

            UiTools.LoadLookUp(edt_lkpRenk, cRenk.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");

            edt_lkpsTedarikci.Properties.DataSource = cTedarikci;
            edt_lkpsTedarikci.Properties.ValueMember = "Deger";
            edt_lkpsTedarikci.Properties.DisplayMember = "Aciklama";
            edt_lkpsTedarikci.EditValue = null;

            UiTools.LoadLookUp(edt_RCinsi, ActiveSession.Srv().GetCombo(ComboFlowComboType.OtomobilCinsi,null).Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
            UiTools.LoadLookUp(edt_Marka, ActiveSession.Srv().GetCombo(ComboFlowComboType.AracMarka, null).Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
        }

        private bool CheckForm() {
            if (UiTools.GetString(edt_Plaka.EditValue).Trim().Length < 7) {
                edt_Plaka.Focus();
                MessageBox.Show("Plaka 7 karakterden az olamaz. Lütfen kontrol ediniz.");
                return false;
            }

            if (UiTools.GetString(edt_Plaka.EditValue).Trim().Length > 9) {
                edt_Plaka.Focus();
                MessageBox.Show("Plaka 9 karakterden büyük olamaz.");
                return false;
            }
            return true;
        }

        private void SaveForm() {
            if (CheckForm() == false) { return; }

            SrvArac nwObj = new SrvArac();
            nwObj.IsActive = cbcIsActive.Checked;
            nwObj.LogoKodu = UiTools.GetString(edt_LogoKod.EditValue).Trim();
            nwObj.Marka = UiTools.GetInt16(edt_Marka.EditValue, true);
            nwObj.ModelYili = UiTools.GetInt16(edt_ModelYili.EditValue, true);
            nwObj.Plaka = UiTools.GetString(edt_Plaka.EditValue).ToUpper();
            nwObj.Renk = UiTools.GetString(edt_lkpRenk.EditValue);
            nwObj.TedarikciId = UiTools.GetGuid(edt_lkpsTedarikci.EditValue, true);
            nwObj.YolcuKapasitesi = UiTools.GetInt32(edt_YolcuKapasitesi.EditValue);

            nwObj.AracSahibiAd      = UiTools.GetString(edt_RAracSahibiAd.EditValue);
            nwObj.AracSahibiSoyad   = UiTools.GetString(edt_RAracSahibiSoyad.EditValue);
            nwObj.Cinsi             = UiTools.GetString(edt_RCinsi.EditValue);
            nwObj.IstiapHaddi       = UiTools.GetInt16(edt_RIstiapHaddi.EditValue);
            nwObj.MotorGucu         = UiTools.GetInt16(edt_RMotorGucu.EditValue);
            nwObj.MotorNo           = UiTools.GetString(edt_RMotorNo.EditValue);
            nwObj.MuayeneTarihi     = Convert.ToDateTime( edt_RMuayeneTarihi.Value);
            nwObj.NetAgirlik        = UiTools.GetInt16(edt_RNetAgirlik.EditValue);
            nwObj.SasiNo            = UiTools.GetString(edt_RSasiNo.EditValue);
            nwObj.SilindirHacmi     = UiTools.GetInt16(edt_RSilindirHacmi.EditValue);
            nwObj.Tipi              = UiTools.GetInt16(edt_RTipi.EditValue,true);

            if (_Id == null) {
                ActiveSession.Srv().AddArac(nwObj);
            }
            else {
                nwObj.Id = _Id.Value;
                ActiveSession.Srv().EditArac(nwObj);
            }
            MessageBox.Show("Ok");
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e) {
            SaveForm();
        }

        private void AracTanim_Load(object sender, EventArgs e) {
            FillCombo();
            isFormLoad = true;

            if (_Id == null) return;
            FillForm();
        }

        private void btnSil_Click(object sender, EventArgs e) {
            if (_Id == null) return;
            ActiveSession.Srv().DeleteArac(_Id.Value);
            this.Close();
        }

        private void FillTabs(string selectedTabName) {
            //if (tabRuhsatBilgi.Name == selectedTabName && isLoadTabBelgeler == false) {
            //    isLoadTabBelgeler = true;
            //}
        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e) {
            FillTabs(e.Page.Name);
        }

        private void edt_Marka_EditValueChanged(object sender, EventArgs e) {
            int? markaId= UiTools.GetInt16(edt_Marka.EditValue, true);
            if (markaId == null || isFormLoad==false) { return; }

            UiTools.LoadLookUp(edt_RTipi, ActiveSession.Srv().GetCombo(ComboFlowComboType.AracModel, markaId.ToString()).Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
            edt_RTipi.ItemIndex = 0;
        }
    }
}