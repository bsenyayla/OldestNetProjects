using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using Kronus.Client.Proxies;

namespace Kronus.Client.Destop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = Common.Libs.Tools.GetBaslik();
           CreateMenu();
        }

        private void CreateMenu()
        {
            try
            {
                DataSet ds=ActiveSession.Core().GetMenu("bsenyayla");

                navBarMenu.Groups.Clear();
                foreach (DataRow itemGrup in ds.Tables[0].Select("UstId is null "))
                {
                    /*Image için alan açılmıştır sadece kullanılması kalmıştır.*/
                    NavBarGroup navBarGrup = new NavBarGroup();
                    navBarGrup.Caption = itemGrup["Ad"].ToString();
                    navBarGrup.LargeImage = Kronus.Client.Destop.Properties.Resources.add;
                    navBarMenu.Groups.Add(navBarGrup);

                    foreach (DataRow item in ds.Tables[0].Select("UstId =" + itemGrup["Id"]))
                    {
                        NavBarItem navBarItem = new NavBarItem();
                        navBarItem.Tag = item;
                        navBarItem.LargeImage = Kronus.Client.Destop.Properties.Resources.add;
                        navBarItem.Caption = item["Ad"].ToString();

                        NavBarItemLink navBarItemLink = new NavBarItemLink(navBarItem);
                        navBarGrup.ItemLinks.Add(navBarItemLink);
                        navBarGrup.Expanded = false;
                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navBarMenu_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                DataRow iAltMenu = e.Link.Item.Tag as DataRow;
                if (iAltMenu != null)
                {
                    Form form = Common.Libs.FormFactory.FormOlustur(iAltMenu["Dll"].ToString(), iAltMenu["NameSpace"].ToString());

                    if (form == null) return;

                    form.Text = iAltMenu["Ad"].ToString();
                    form.MdiParent = this;
                    form.Show();
                }
            }

            catch (Exception ex)
            {
                string msg = "Menu Oluşturma hatası !\n Hata :" + ex.Message + "\n Hata Detay:" + ex.InnerException;
                MessageBox.Show(msg, "Hata Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void barButtonItemCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Kronus.Client.Common.Forms.Form2 frm = new Common.Forms.Form2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemTheme_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Common.Forms.Theme frm = new Common.Forms.Theme();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void barButtonMenuRefresh_ItemClick(object sender, ItemClickEventArgs e) {
            CreateMenu();
        }

        private void barButtonIAppInfo_ItemClick(object sender, ItemClickEventArgs e) {
            Common.Management.AppGeneralInfo frm = new Common.Management.AppGeneralInfo();
            frm.Show();
        }

        private void barButtonItemAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActiveSession.Close();
        }

        private void LotCalcBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Kronus.Client.Common.Management.LotCalcForm frm = new Common.Management.LotCalcForm();
            frm.Show();
        }
    }
}