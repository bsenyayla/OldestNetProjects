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
    public partial class TedarikciTanim : Common.Forms.BaseXtraForm
    {
        public Guid? _Id = null;
        List<ComboItem> cBanka = new List<ComboItem>();
        FormOperation fnFormOperation = new FormOperation();

        public TedarikciTanim() {
            InitializeComponent();
        }

        private bool CheckForm() {
            return true;
        }

        private void SaveForm() {
            if (CheckForm() == false) { return; }
            SrvTedarikci nwObj = new SrvTedarikci();
            nwObj.Aciklama      = UiTools.GetString(edt_Aciklama.EditValue);
            nwObj.Adres         = UiTools.GetString(edt_Adres.EditValue);
            nwObj.Banka         = UiTools.GetString(edt_LBanka.EditValue);
            nwObj.CariAd        = UiTools.GetString(edt_CariAd.EditValue);
            nwObj.CariKod       = UiTools.GetString(edt_CariKod.EditValue);
            nwObj.CreateUser    = Common.Libs.Tools.DomainName();
            nwObj.Fax           = UiTools.GetString(edt_FaxNo.EditValue);
            nwObj.Gsm           = UiTools.GetString(edt_GsmNo.EditValue);
            nwObj.HesapNo       = UiTools.GetString(edt_HesapNo.EditValue);
            nwObj.IBAN          = UiTools.GetString(edt_IBAN.EditValue);
            nwObj.IsActive      = cbcIsActive.Checked;
            nwObj.Sube          = UiTools.GetString(edt_Sube.EditValue);
            nwObj.Telefon       = UiTools.GetString(edt_TelefonNo.EditValue);
            nwObj.VergiDairesi  = UiTools.GetString(edt_VergiDairesi.EditValue);
            nwObj.VergiNo       = UiTools.GetString(edt_VergiNo.EditValue);
            nwObj.YetkiliKisi   = UiTools.GetString(edt_YetkiliKisi.EditValue);

            string msg = "";
            if (_Id != null) {
                nwObj.Id = _Id.Value;
                ActiveSession.Srv().EditTedarikci(nwObj);
                msg = "edit ok";
            }
            else {
                nwObj.Id = Guid.NewGuid();
                ActiveSession.Srv().AddTedarikci(nwObj);
                msg = "insert ok";
            }

            MessageBox.Show(msg, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FillCombos() {
            cBanka.Add(new ComboItem { Aciklama = "Seçiniz..", Deger = null });
            cBanka.AddRange(ActiveSession.Srv().GetCombo(ComboFlowComboType.Banka, null));
            UiTools.LoadLookUp(edt_LBanka, cBanka.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(),"Seçiniz");
        }

        private void FillForm() {
            TedarikciS ds = ActiveSession.Srv().GetTedarikciById(_Id.Value);
            if (ds == null) { return; }

            edt_Aciklama.EditValue = ds.Aciklama;
            edt_Adres.EditValue = ds.Adres;
            edt_CariAd.EditValue = ds.CariAd;
            edt_CariKod.EditValue = ds.CariKod;
            edt_FaxNo.EditValue = ds.Fax;
            edt_GsmNo.EditValue = ds.Gsm;
            edt_HesapNo.EditValue = ds.HesapNo;
            edt_IBAN.EditValue = ds.IBAN;
            edt_LBanka.EditValue = Common.Libs.UiTools.GetString(ds.Banka);
            edt_Sube.EditValue = ds.Sube;
            edt_TelefonNo.EditValue = ds.Telefon;
            edt_VergiDairesi.EditValue = ds.VergiDairesi;
            edt_VergiNo.EditValue = ds.VergiNo;
            edt_YetkiliKisi.EditValue = ds.YetkiliKisi;
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e) {
            SaveForm();
        }

        private void TedarikciTanim_Load(object sender, EventArgs e) {
            FillCombos();
            if (_Id != null) {
                FillForm();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e) {
            fnFormOperation.CleanForm(this);
            _Id = null;
        }
    }
}
