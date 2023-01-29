using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;

namespace Kronus.Client.Common.Forms
{
    public partial class Theme : BaseXtraForm
    {
        public Theme()
        {
            InitializeComponent();
        }

        bool _loaded = false;

        private void Theme_Load(object sender, EventArgs e)
        {
            try
            {
                var skins = DevExpress.Skins.SkinManager.Default.Skins;
                this.themeGrid.DataSource = skins;
            }
            catch
            {
            }

            finally
            {
                _loaded = true;
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (_loaded)
            {
                string ad = (themeGridView.GetRow(themeGridView.FocusedRowHandle) as SkinContainer).SkinName;
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(ad);
                Common.Libs.Tools.AddAyar("Theme", ad);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (_loaded)
            {
                string ad = (themeGridView.GetRow(themeGridView.FocusedRowHandle) as SkinContainer).SkinName;
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(ad);
                Common.Libs.Tools.AddAyar("Theme", ad);
            }
        }
    }
}