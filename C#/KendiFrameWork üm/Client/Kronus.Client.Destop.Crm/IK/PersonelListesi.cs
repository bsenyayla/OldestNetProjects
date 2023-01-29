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
    public partial class PersonelListesi : Common.Forms.BaseXtraForm
    {
        List<ComboItem> cDepartman = new List<ComboItem>();
        public PersonelListesi()
        {
            InitializeComponent();
            gridMain.GridDoubleClick += new EventHandler(UserControlGrid_GridDoubleClick);
        }

        private void FillCombobox()
        {
            cDepartman.Add(new ComboItem { Aciklama = "Hepsi..", Deger = null });
            cDepartman.AddRange(ActiveSession.Crm().GetDepartmanListForCombo());
            UiTools.LoadLookUp(lkpDepartman, cDepartman.Select(p => new UiTools.ComboData { Aciklama = p.Aciklama, Deger = p.Deger }).ToList(), "Hepsi..");
            UiTools.LoadLookUpFromString(lkpDurum, "Hepsi;null|Aktif;true|Pasif;false", "Hepsi");
        }

        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ReportParamsPersonelShortFilter rptParams = new ReportParamsPersonelShortFilter();
            rptParams.Ad = txtAd.Text;
            rptParams.Soyad = txtSoyad.Text;
            rptParams.DomainName = txtDomainName.Text;
            rptParams.Departman = UiTools.GetLookUpEditValue(lkpDepartman);
            rptParams.TcKimlikNo = txtTcNo.Text;
            rptParams.IsActive = UiTools.GetBoolean(lkpDurum.EditValue, true);
            gridMain.DataSource = ActiveSession.Crm().GetPersonelShortList(rptParams);
        }

        protected void UserControlGrid_GridDoubleClick(object sender, EventArgs e) {
            PersonelShort selectedRow = gridMain.GetFocusedRow as PersonelShort;
            if (selectedRow == null) return;
            PersonelTanim frm = new PersonelTanim();
            frm._Id = selectedRow.Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }




    }
}
