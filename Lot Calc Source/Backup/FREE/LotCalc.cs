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
    public partial class LotCalc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string strLayoutPath = "";
        public LotCalc()
        {
            InitializeComponent();
        }

        private void LotCalc_Load(object sender, EventArgs e)
        {
            strLayoutPath = Utils.GetLayoutPath() + @"/LotCalc_Layout.xml";
            //OpactTrackBar.Value = (int)(this.Opacity * 100);
            TutarcalcEdit.Focus();
            LoadLayout();
        }

        private void LotCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLayout();
        }


        private void SaveLayout() {
            if ((this.Location.X < 0) || (this.Location.Y < 0)) { return; }

            XmlTextWriter xmlWriter = new XmlTextWriter(strLayoutPath, Encoding.UTF8);
            xmlWriter.WriteStartDocument(true);
            xmlWriter.WriteStartElement("LotCalcLayout");
            xmlWriter.WriteElementString("X", this.Location.X.ToString());
            xmlWriter.WriteElementString("Y", this.Location.Y.ToString());
            xmlWriter.WriteElementString("Width", this.Width.ToString());
            xmlWriter.WriteElementString("Height", this.Height.ToString());
            xmlWriter.WriteElementString("Opact", this.OpactTrackBar.Value.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private void LotCalc_Shown(object sender, EventArgs e)
        {
            TutarcalcEdit.Focus();
        }

        private void LoadLayout() {
            try
            {
                if (File.Exists(strLayoutPath) == true)
                {
                    Application.DoEvents();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(strLayoutPath);
                    XmlNodeList xxc = xdoc.GetElementsByTagName("LotCalcLayout");
                    int x = Convert.ToInt32(xxc[0]["X"].InnerText);
                    int y = Convert.ToInt32(xxc[0]["Y"].InnerText);
                    this.Height = Convert.ToInt32(xxc[0]["Height"].InnerText);
                    this.Width = Convert.ToInt32(xxc[0]["Width"].InnerText);
                    OpactTrackBar.Value = Convert.ToInt32(xxc[0]["Opact"].InnerText);
                    //this.Opacity = Convert.ToInt32(xxc[0]["Opact"].InnerText) / 10.0;
                    this.Location = new Point(x, y);
                }
            }
            catch
            { }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hesapla() {
            if (AlisFiyatcalcEdit.Value == null || AlisFiyatcalcEdit.Value == 0) return;
            if (SatisFiyatcalcEdit.Value == null || SatisFiyatcalcEdit.Value == 0) return;

            decimal alinabilirLot = 0, toplamPara = 0;
            decimal alisfiyati, alisTutari;

            alisfiyati = AlisFiyatcalcEdit.Value;
            toplamPara = TutarcalcEdit.Value;

            if (LTradio.EditValue.ToString() == "T")
            {
                alinabilirLot = Math.Floor(toplamPara / alisfiyati);
            }
            else
            {
                alinabilirLot = LotcalcEdit.Value;
            }
            
            if (alinabilirLot == 0) return;
            alisTutari = alinabilirLot * alisfiyati;
            decimal satisFiyati = 0, satisTutari = 0;
            satisFiyati = SatisFiyatcalcEdit.Value;

            satisTutari = alinabilirLot * satisFiyati;
            decimal donusTutari = 0, oran = 0;
            donusTutari = satisTutari - alisTutari;
            oran = (int)Math.Floor((donusTutari * 100) / alisTutari);
            Oranlbl.Text = "%" + oran.ToString();
            if (oran > 0) { Oranlbl.ForeColor = Color.Green; } else { Oranlbl.ForeColor = Color.Red; }

            DonusTutarcalcEdit.Value = donusTutari;
            SatisTutarcalcEdit.Value = satisTutari;
            AlisTutarcalcEdit.Value = alisTutari;
            AlinabilirLotcalcEdit.Value = alinabilirLot;
        
        }

        private void Hesaplabtn_Click(object sender, EventArgs e)
        {
            Hesapla();
        }



        private void OpactTrackBar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            double dd = 0;
            
            dd=OpactTrackBar.Value / 10.0;

            this.Opacity = dd;
        }

        private void OpactTrackBar_EditValueChanged(object sender, EventArgs e)
        {
            double dd = 0;

            dd = OpactTrackBar.Value / 10.0;

            this.Opacity = dd;
        }


        private void LotcalcEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                Hesapla();
            }
        }

        private void TutarcalcEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Hesapla();
            }
        }

        private void AlisFiyatcalcEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Hesapla();
            }
        }

        private void SatisFiyatcalcEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Hesapla();
            }
        }
    }
}