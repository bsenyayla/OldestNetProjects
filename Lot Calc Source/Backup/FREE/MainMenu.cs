using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Xml;
using System.IO;


namespace FREE
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string strLayoutPath = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            strLayoutPath = Utils.GetLayoutPath() + @"/MainMenu_Layout.xml";
            LoadLayout();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveLayout();
        }

        private void SaveLayout()
        {
            if ((this.Location.X < 0) || (this.Location.Y < 0)) { return; }

            XmlTextWriter xmlWriter = new XmlTextWriter(strLayoutPath, Encoding.UTF8);
            xmlWriter.WriteStartDocument(true);
            xmlWriter.WriteStartElement("MainMenuLayout");
            xmlWriter.WriteElementString("LocationX", this.Location.X.ToString());
            xmlWriter.WriteElementString("LocationY", this.Location.Y.ToString());
            xmlWriter.WriteElementString("Width", this.Width.ToString());
            xmlWriter.WriteElementString("Height", this.Height.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {

        }

        private void LoadLayout() {
            try
            {
                if (File.Exists(strLayoutPath) == true)
                {
                    Application.DoEvents();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(strLayoutPath);
                    XmlNodeList xxc = xdoc.GetElementsByTagName("MainMenuLayout");
                    int x = Convert.ToInt32(xxc[0]["LocationX"].InnerText);
                    int y = Convert.ToInt32(xxc[0]["LocationY"].InnerText);
                    this.Height = Convert.ToInt32(xxc[0]["Height"].InnerText);
                    this.Width = Convert.ToInt32(xxc[0]["Width"].InnerText);
                    this.Location = new Point(x, y);
                }
            }
            catch
            { }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LotCalc frm = new LotCalc();
            frm.Show();
        }

        private void JavaMatriksStnavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            JavaMatriksST frm = new JavaMatriksST();
            frm.Show();
        }

        private void ParaGirisCikisnavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ParaGirisCikisi frm = new ParaGirisCikisi();
            frm.Show();
        }

        private void DokumannavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Dokuman frm = new Dokuman();
            frm.Show();
        }

        private void HaberAnalizinavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HaberAnalizi frm = new HaberAnalizi();
            frm.Show();
        }

        private void TakasBilgilerinavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TakasBilgileri frm = new TakasBilgileri();
            frm.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            DetayBilancoGelirTablo frm = new DetayBilancoGelirTablo();
            frm.Show();
        }

        private void navBarItemTakas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TakasFrm frm = new TakasFrm();
            frm.Show();
        }
    }
}