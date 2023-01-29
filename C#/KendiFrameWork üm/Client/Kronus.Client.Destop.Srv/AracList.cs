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
    public partial class AracList : Common.Forms.BaseXtraForm
    {
        public AracList() {
            InitializeComponent();
            gridMain.GridDoubleClick += new EventHandler(UserControlGrid_GridDoubleClick);
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        protected void UserControlGrid_GridDoubleClick(object sender, EventArgs e) {
            AracShort selectedRow = gridMain.GetFocusedRow as AracShort;
            if (selectedRow == null) return;

            AracTanim frm = new AracTanim();
            frm._Id = selectedRow.Id;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e) {
            ReportParamsAracShortFilter rptParams = new ReportParamsAracShortFilter();
            rptParams.Plaka = txtPlaka.Text;
            rptParams.Kod = txtKod.Text;
            
            rptParams.Tedarikci = Common.Libs.UiTools.GetGuid(edt_lkpsTedarikci.EditValue,true);
            rptParams.IsActive = Common.Libs.UiTools.GetBoolean(lkpDurum.EditValue, true);

            List<AracShort> ds = ActiveSession.Srv().Arac_GetAracList(rptParams);
            gridMain.DataSource = ds;
        }

        private void FillCombos() {
            List<ComboItem> cTedarikci = new List<ComboItem>();
            cTedarikci.Add(new ComboItem { Aciklama = "Hepsi", Deger = null });
            cTedarikci.Add(new ComboItem { Aciklama = "Öz Mal", Deger = new Guid().ToString() });
            cTedarikci.AddRange(ActiveSession.Srv().GetCombo(ComboFlowComboType.Tedarikci,null));

            edt_lkpsTedarikci.Properties.DataSource = cTedarikci;
            edt_lkpsTedarikci.Properties.ValueMember = "Deger";
            edt_lkpsTedarikci.Properties.DisplayMember = "Aciklama";
            edt_lkpsTedarikci.EditValue = null;
            
            UiTools.LoadLookUpFromString(lkpDurum, "Hepsi;null|Aktif;true|Pasif;false", "Hepsi");
        }

        private void AracList_Load(object sender, EventArgs e) {
            FillCombos();
        }
    }
}
