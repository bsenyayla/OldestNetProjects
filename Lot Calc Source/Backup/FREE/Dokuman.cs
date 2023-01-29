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
using DevExpress.XtraRichEdit;



namespace FREE
{
    public partial class Dokuman : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string strLayoutPath = "";

        public class DosyaInfo
        {
            public string DosyaAd;
            public string Adres;
            public string Durum;
        }

        List<DosyaInfo> dosyaBilgi =new List<DosyaInfo>();
        public Dokuman()
        {
            strLayoutPath = Utils.GetLayoutPath() + @"/CCC.xml";
            InitializeComponent();
            LoadDokumanList();
        }

        private DosyaInfo GetDosyaInfo(string dosyaAd) {
            foreach (DosyaInfo dr in dosyaBilgi)
            {
                if (dr.DosyaAd == dosyaAd)
                {
                    return dr;
                }
            }
            return null;
        }


        private void listBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            string df = "";
            MessageBox.Show(listBoxControl1.SelectedValue.ToString());
           
        }

        private void LoadDokumanList()
        {
            try
            {
                if (File.Exists(strLayoutPath) == true)
                {
                    Application.DoEvents();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(strLayoutPath);
                    XmlNodeList xxc1 = xdoc.GetElementsByTagName("RRRR");
                    for (int i = 0; i < xxc1.Count; i++) {
                        listBoxControl1.Items.Add(xxc1[i]["LocationX"].InnerText);
                        
                        DosyaInfo rc=new DosyaInfo();
                        rc.Adres="";
                        rc.DosyaAd=xxc1[i]["LocationX"].InnerText;
                        rc.Durum="";
                        dosyaBilgi.Add(rc);
                    }
                }
            }
            catch
            { }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dosyaAd = txtDosyaAdi.Text;
            string dosya = Utils.GetLayoutPath() + @"/" + dosyaAd + ".rtf";
            richEditControl1.SaveDocument(dosya, DocumentFormat.Rtf);

            listBoxControl1.Items.Add(dosyaAd);

            DosyaInfo rc = new DosyaInfo();
            rc.Adres = dosya;
            rc.DosyaAd = dosyaAd;
            rc.Durum = "";
            dosyaBilgi.Add(rc);




        }
    }
}