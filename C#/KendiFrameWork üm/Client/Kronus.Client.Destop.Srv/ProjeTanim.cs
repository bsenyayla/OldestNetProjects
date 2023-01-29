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
    public partial class ProjeTanim : Common.Forms.BaseXtraForm
    {
        FormOperation fnFormOperation = new FormOperation();
        public Guid? _Id = null;
        List<ComboItem> cFaturaTipi = new List<ComboItem>();
        List<ComboItem> cProjeTipi = new List<ComboItem>();
        List<ComboItem> cPersonel = new List<ComboItem>();
        
        public ProjeTanim() {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FillForm() {
            ProjeS ds = ActiveSession.Srv().GetProjeById(_Id.Value);
            if (ds == null) { return; }

            edt_lkpProjeLideri.EditValue = UiTools.GetString(ds.ProjeLideri);
            edt_lkpFaturaTipi.EditValue = UiTools.GetString(ds.FaturaTipi);
            edt_lkpMusteriTemsilcisi.EditValue = UiTools.GetString(ds.MusteriTemsilcisi);
            edt_lkpSozlesmeyiYapan.EditValue = UiTools.GetString(ds.SozlesmeyiYapan);
            edt_lkpTip.EditValue = UiTools.GetString(ds.Tipi);

            edt_ProjeId.EditValue = ds.Id;
            edt_Ad.EditValue = ds.Ad;
            edt_BedelsizSefer.Value = UiTools.GetInt32(ds.AracBedelsizSeferSayisi);
            edt_FaturaGunu.EditValue = UiTools.GetInt32(ds.FaturaGunu);
            edt_FaturaHizmetKodu.EditValue = ds.FaturaHizmetKodu;

            edt_firmaYEmail.EditValue = ds.FirmaYetkiliEmail;
            edt_FirmaYFax.EditValue = ds.FirmaYetkiliFax;
            edt_FirmaYetkili.EditValue = ds.FirmaYetkilisi;
            edt_FirmaYtel.EditValue = ds.FirmaYetkiliTel;
            edt_HostesHakEdisTutari.EditValue = ds.HostesHakEdisTutari;
            cbcIsActive.Checked = ds.IsActive.Value;
            edt_IskontoOrani.EditValue = ds.IskontoOrani;
            edt_Kod.EditValue = ds.Kod;
            edt_SoforHakedisTutari.EditValue = ds.SoforHakEdisTutari;
            edt_SozlesmeBasTarih.EditValue = ds.SozlesmeBaslangicTarihi;
            edt_SozlesmeBitisTarih.EditValue = ds.SozlesmeBitisTarihi;
            edt_WebSite.EditValue = ds.WebSitesi;
        }

        private void FillCombo() {
            cProjeTipi = ActiveSession.Srv().GetCombo(ComboFlowComboType.ProjeTipi,null);
            cPersonel = ActiveSession.Srv().GetPersonelListForCombo();
            cFaturaTipi = ActiveSession.Srv().GetCombo(ComboFlowComboType.FaturaTipi,null);
            UiTools.LoadLookUp(edt_lkpTip, cProjeTipi.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
            UiTools.LoadLookUp(edt_lkpProjeLideri, cPersonel.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
        }

        private void ProjeTanim_Load(object sender, EventArgs e) {
            FillCombo();
            if (_Id != null) {
                FillForm();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e) {
            Save();
        }

        private bool CheckForm() {
            if (UiTools.GetString(edt_lkpTip.EditValue) == "") {
                MessageBox.Show("Proje Tipi Boş olamaz .Lüften proje tipini seçiniz.");
                return false;
            }
            return true;
        }

        private void Sil() {
            if (_Id == null) return;
            ActiveSession.Srv().DeleteProje(_Id.Value);
            fnFormOperation.CleanForm(this);
            _Id = null;
        }

        private void Save() {
            if (CheckForm() == false) { return; }
            SrvProje nwProje = new SrvProje();
            nwProje.Ad = UiTools.GetString(edt_Ad.EditValue);
            nwProje.AracBedelsizSeferSayisi = UiTools.GetInt32(edt_BedelsizSefer.EditValue, true);
            nwProje.CreateUser = "sys";
            nwProje.FaturaGunu = UiTools.GetInt32(edt_FaturaGunu.EditValue, true);
            nwProje.FaturaHizmetKodu = UiTools.GetString(edt_FaturaHizmetKodu.EditValue);
            nwProje.FaturaTipi = UiTools.GetInt32(edt_lkpFaturaTipi.EditValue, true);
            nwProje.FirmaYetkiliEmail = UiTools.GetString(edt_firmaYEmail.EditValue);
            nwProje.FirmaYetkiliFax = UiTools.GetString(edt_FirmaYFax.EditValue);
            nwProje.FirmaYetkilisi = UiTools.GetString(edt_FirmaYetkili.EditValue);
            nwProje.FirmaYetkiliTel = UiTools.GetString(edt_FirmaYtel.EditValue);
            nwProje.HostesHakEdisTutari = UiTools.GetDecimal(edt_HostesHakEdisTutari.EditValue, true);
            nwProje.IskontoOrani = UiTools.GetDecimal(edt_IskontoOrani.EditValue, true);

            nwProje.Kod = UiTools.GetString(edt_Kod.EditValue);
            nwProje.SoforHakEdisTutari = UiTools.GetDecimal(edt_SoforHakedisTutari.EditValue, true);
            nwProje.SozlesmeBaslangicTarihi = UiTools.GetDateEditValue(edt_SozlesmeBasTarih);
            nwProje.SozlesmeBitisTarihi = UiTools.GetDateEditValue(edt_SozlesmeBitisTarih);
            nwProje.WebSitesi = UiTools.GetString(edt_WebSite.EditValue);
            nwProje.IsActive = cbcIsActive.Checked;

            nwProje.MusteriTemsilcisi = UiTools.GetLookUpEditValue(edt_lkpMusteriTemsilcisi);
            nwProje.ProjeLideri = UiTools.GetLookUpEditValue(edt_lkpProjeLideri);
            nwProje.Tipi = UiTools.GetString(edt_lkpTip.EditValue);
            nwProje.FaturaTipi = UiTools.GetInt32(edt_lkpFaturaTipi.EditValue, true);
            nwProje.SozlesmeyiYapan = UiTools.GetLookUpEditValue(edt_lkpSozlesmeyiYapan);

            string msg = "";
            if (_Id != null) {
                nwProje.Id = _Id.Value;
                ActiveSession.Srv().EditProje(nwProje);
                msg = "edit ok";
            }
            else {
                ActiveSession.Srv().AddProje(nwProje);
                msg = "insert ok";
            }

            MessageBox.Show(msg, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xtraTabControl1_Click(object sender, EventArgs e) {
            switch (xtraTabControl1.SelectedTabPage.Name) {
                case "xtraTabMusteriTemsilci":
                if (edt_lkpMusteriTemsilcisi.Properties.DataSource == null) {
                    UiTools.LoadLookUp(edt_lkpMusteriTemsilcisi, cPersonel.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
                }
                break;

                case "xtraTabFinansal":
                if (edt_lkpFaturaTipi.Properties.DataSource == null) {
                    UiTools.LoadLookUp(edt_lkpFaturaTipi, cFaturaTipi.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
                }
                if (edt_lkpSozlesmeyiYapan.Properties.DataSource == null) {
                    UiTools.LoadLookUp(edt_lkpSozlesmeyiYapan, cPersonel.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "");
                }
                break;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e) {
            fnFormOperation.CleanForm(this);
            _Id = null;
        }

        private void btnSil_Click(object sender, EventArgs e) {
            Sil();
        }
    }
}