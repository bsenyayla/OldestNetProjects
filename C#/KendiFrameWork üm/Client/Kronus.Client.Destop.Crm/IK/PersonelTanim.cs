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
using Kronus.Client.Proxies.CrmService;
using Kronus.Client.Common.Libs;

namespace Kronus.Client.Destop.Crm.IK
{
    public partial class PersonelTanim : Common.Forms.BaseXtraForm
    {
        public Guid _Id;
        private Guid? _EhliyetId    =  null;
        private bool _IsLoad        =  false, isLoadTabEhliyet=false;
        Proxies.CrmService.CrmServiceClient ws;

        public PersonelTanim() {
            ws = new Proxies.CrmService.CrmServiceClient();
            InitializeComponent();
        }

        private void FillCombos() {
            Proxies.CrmService.CrmServiceClient ws = new Proxies.CrmService.CrmServiceClient();
            UiTools.LoadLookUpEdit(lkpDepartman, ws.GetDepartmanListForCombo(), null);
            UiTools.LoadLookUpEdit(lkpGorev, ws.GetGorevListForCombo(), null);
            UiTools.LoadLookUpEdit(lkpFirma, ws.GetFirmaListForCombo(), null);

            ComboItem[] personelList = ws.GetPersonelListForCombo();
            UiTools.LoadLookUpEdit(lkpBirinciYonetici, personelList, null);
            UiTools.LoadLookUpEdit(lkpIkinciYonetici, personelList, null);
            ws.Close();

            UiTools.LoadLookUpV1(lkpOdemeTipi, ActiveSession.Crm().GetCombo(ComboFlowComboType.OdemeTipi, ""));
            UiTools.LoadLookUpV1(lkpCalismaSekli, ActiveSession.Crm().GetCombo(ComboFlowComboType.CalismaSekli, ""));
        }

        private void FillForm(Guid Id) {
            Personel personelInfo = ws.GetPersonelById(Id);
            if (personelInfo == null) {
                return;
            }

            txtAd.EditValue = personelInfo.Ad;
            txtSoyad.EditValue = personelInfo.Soyad;
            txtDomainName.EditValue = personelInfo.DomainName;
            txtTcNo.EditValue = personelInfo.TcKimlikNo;
            Adres.EditValue = personelInfo.Adres;

            UiTools.SetLookUpEditValue(lkpBirinciYonetici, personelInfo.BirinciYonetici);
            UiTools.SetLookUpEditValue(lkpIkinciYonetici, personelInfo.IkinciYonetici);
            UiTools.SetLookUpEditValue(lkpBolum, personelInfo.BolumId);
            UiTools.SetLookUpEditValue(lkpDepartman, personelInfo.DepartmanId);
            UiTools.SetLookUpEditValue(lkpFirma, personelInfo.FirmaId);
            UiTools.SetLookUpEditValue(lkpFirmaLokasyon, personelInfo.FirmaLokasyonId);
            UiTools.SetLookUpEditValue(lkpGorev, personelInfo.GorevId);

            lkpCalismaSekli.EditValue = UiTools.GetString(personelInfo.CalismaSekli);
            lkpOdemeTipi.EditValue = UiTools.GetString(personelInfo.OdemeTipi);

            CikisTarihi.EditValue = personelInfo.CikisTarihi;
            Cinsiyet.EditValue = personelInfo.Cinsiyet;
            DogumTarihi.EditValue = personelInfo.DogumTarihi;
            Email.EditValue = personelInfo.Email;
            EmailIs.EditValue = personelInfo.EmailIs;
            GirisTarihi.EditValue = personelInfo.GirisTarihi;
            GsmNo.EditValue = personelInfo.GsmNo;

            MedeniHal.EditValue = personelInfo.MedeniHali;
            TelefonNo.EditValue = personelInfo.TelefonNo;
            TelefonNoIs.EditValue = personelInfo.TelefonNoIs;
            chkAktif.Checked = personelInfo.IsActive.Value;

            //personelInfo.ProfilFoto
        }

        private bool CheckForm() {
            if (lkpCalismaSekli.EditValue == null) {
                lkpCalismaSekli.Focus();
                MessageBox.Show("Çalışma şekli boş olmamalıdır.Lütfen kontrol edininiz.");
                return false;
            }

            if (lkpOdemeTipi.EditValue == null) {
                lkpOdemeTipi.Focus();
                MessageBox.Show("Ödeme tipi alanı boş olmamalıdır.Lütfen kontrol edininiz.");
                return false;
            }
            return true;
        }

        private void SaveForm() {
            if (CheckForm() == false) {
                return;
            }

            #region Ehliyet
            if (isLoadTabEhliyet == true) {
                CrmEhliyet nwEhliyet = new CrmEhliyet();
                //nwEhliyet.Img_1 = "";
                //nwEhliyet.Img_2 = "";
                nwEhliyet.PersonelId = _Id;
                nwEhliyet.Ad         = eh_Ad.EditValue.ToString();
                nwEhliyet.BelgeNo    = eh_BelgeNo.EditValue.ToString();
                nwEhliyet.Sinif     = eh_Sinif.EditValue.ToString();
                nwEhliyet.Soyad     = eh_Soyad.EditValue.ToString();
                nwEhliyet.VerilisIl = eh_VerilisIl.EditValue.ToString();
                nwEhliyet.VerilisIlce = eh_VerilisIlce.EditValue.ToString();
                nwEhliyet.VerilisTarihi = eh_VerilisTarihi.DateTime;

                if (_EhliyetId == null) {
                    _EhliyetId = Guid.NewGuid(); 
                    nwEhliyet.Id =_EhliyetId.Value;
                    ActiveSession.Crm().AddEhliyet(nwEhliyet);
                }
                else {
                    nwEhliyet.Id = _EhliyetId.Value;
                    ActiveSession.Crm().EditEhliyet(nwEhliyet);
                }
            }
            #endregion Ehliyet

            #region Personel
            CrmPersonel newPersonel = new CrmPersonel();
            newPersonel.Ad          = txtAd.EditValue.ToString();
            newPersonel.Adres       = Adres.EditValue.ToString();
            newPersonel.BirinciYonetici = Common.Libs.UiTools.GetLookUpEditValue(lkpBirinciYonetici);
            newPersonel.BolumId     = Common.Libs.UiTools.GetLookUpEditValue(lkpBolum);
            newPersonel.GirisTarihi = Common.Libs.UiTools.GetDateEditValue(GirisTarihi);
            newPersonel.CikisTarihi = Common.Libs.UiTools.GetDateEditValue(CikisTarihi);
            newPersonel.DogumTarihi = Common.Libs.UiTools.GetDateEditValue(DogumTarihi);
            newPersonel.Cinsiyet    = Cinsiyet.EditValue.ToString();
            newPersonel.CreateUser  = Common.Libs.Tools.DomainName();
            newPersonel.DepartmanId = Common.Libs.UiTools.GetLookUpEditValue(lkpDepartman);
            newPersonel.DomainName  = txtDomainName.Text;
            newPersonel.Email       = Email.EditValue.ToString();
            newPersonel.EmailIs     = EmailIs.EditValue.ToString();
            newPersonel.FirmaId     = Common.Libs.UiTools.GetLookUpEditValue(lkpFirma);
            newPersonel.FirmaLokasyonId = Common.Libs.UiTools.GetLookUpEditValue(lkpFirmaLokasyon);
            newPersonel.CalismaSekli = Common.Libs.UiTools.GetString(lkpCalismaSekli.EditValue);
            newPersonel.OdemeTipi   = Common.Libs.UiTools.GetString(lkpOdemeTipi.EditValue);
            newPersonel.GorevId     = Common.Libs.UiTools.GetLookUpEditValue(lkpGorev);
            newPersonel.GsmNo       = GsmNo.EditValue.ToString();
            newPersonel.IkinciYonetici = Common.Libs.UiTools.GetLookUpEditValue(lkpIkinciYonetici);
            newPersonel.MedeniHali  = MedeniHal.EditValue.ToString();
            //newPersonel.ProfilFoto
            newPersonel.Soyad = txtSoyad.Text;
            newPersonel.TcKimlikNo = txtTcNo.Text;
            newPersonel.TelefonNo = TelefonNo.EditValue.ToString();
            newPersonel.TelefonNoIs = TelefonNoIs.EditValue.ToString();
            newPersonel.IsActive = chkAktif.Checked;

            string msg = "";
            if (_Id != null) {
                newPersonel.Id = _Id;
                ActiveSession.Crm().EditPersonel(newPersonel);
                msg = "edit ok";
            }
            else {
                newPersonel.Id = Guid.NewGuid();
                ActiveSession.Crm().AddPersonel(newPersonel);
                msg = "insert ok";
            }
            #endregion Personel

            MessageBox.Show(msg, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FillTabs(string selectedTabName) {
            if (TabPageEhliyet.Name == selectedTabName && isLoadTabEhliyet == false) {
                isLoadTabEhliyet = true;
                EhliyetS rcEhliyet=ActiveSession.Crm().GetEhliyetByPersonelId(_Id);
                if (rcEhliyet == null) { return; }
                eh_Ad.EditValue             = rcEhliyet.Ad;
                eh_BelgeNo.EditValue        = rcEhliyet.BelgeNo;
                eh_Sinif.EditValue          = rcEhliyet.Sinif;
                eh_Soyad.EditValue          = rcEhliyet.Soyad;
                eh_VerilisIl.EditValue      = rcEhliyet.VerilisIl;
                eh_VerilisIlce.EditValue    = rcEhliyet.VerilisIlce;
                eh_VerilisTarihi.EditValue  = rcEhliyet.VerilisTarihi;
                _EhliyetId = rcEhliyet.Id;
            }
        }

        #region Events
        private void btnKaydet_Click(object sender, EventArgs e) {
            SaveForm();
        }

        private void PersonelTanim_FormClosing(object sender, FormClosingEventArgs e) {
            ws.Close();
        }

        

        private void PersonelTanim_Load(object sender, EventArgs e) {
            FillCombos();
            if (_Id != new Guid()) {
                FillForm(_Id);
            }
            _IsLoad = true;
        }

        private void lkpDepartman_EditValueChanged(object sender, EventArgs e) {
            if (_IsLoad == false) {
                return;
            }
            if (lkpDepartman.GetSelectedDataRow() == null) {
                return;
            }

            Guid guidSelected = new Guid((lkpDepartman.GetSelectedDataRow() as ComboItem).Deger);
            UiTools.LoadLookUpEdit(lkpBolum, ws.GetBolumListForCombo(guidSelected), null);
        }

        private void btnYeni_Click(object sender, EventArgs e) {

            //lkpBirinciYonetici.EditValue = "dc640458-bde4-4b3f-998b-3d370035b541";
            //return;
            //picProfil.Image = @"C://a.png";
            //picProfil.Image.Save("c://b.jpg");

            //picProfil.Image = Image.FromFile(@"C:\\a.png");
            picProfil.LoadAsync("http://resimli.net/wp-content/uploads/resim-2.jpg");
        }

        private void lkpFirma_EditValueChanged(object sender, EventArgs e) {
            //if (_IsLoad == false) {
            //    return;
            //}
            if (lkpFirma.GetSelectedDataRow() == null) {
                return;
            }
            var item = lkpFirma.GetSelectedDataRow() as ComboItem;
            Common.Libs.UiTools.LoadLookUpEdit(lkpFirmaLokasyon, ws.GetFirmaLokasyonListForCombo(new Guid(item.Deger)), null);
        }
        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e) {

        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e) {
            FillTabs(e.Page.Name);
        }

        #endregion Events
    }
}
