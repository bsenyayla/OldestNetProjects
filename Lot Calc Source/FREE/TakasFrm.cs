using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FREE
{
    public partial class TakasFrm : Form
    {
        public TakasFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            WebClient wc = new WebClient();
            wc.DownloadFile("http://www.matriksdata.com/Matriks/a_JAVA_Takas.asp?Hisse=1177", @"c:\logoIletisim.txt");

            string dft = "";


            string loginurl = "http://www.matriksdata.com/Matriks/a_JAVA_Takas.asp?Hisse=1177"; // ba�lan�lacak olan URL
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(loginurl); // HttpWebRequest s�n�f� ile url e istek olu�turuyoruz
            request.Method = "POST"; // kullanaca��m�z metodu yaz�yoruz
            request.Timeout = 100000; // timeout veriyoruz
            request.ContentType = "application/x-www-form-urlencoded"; // content type � veriyoruz
            

            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // response edebiliriz

            //StreamReader reader = new StreamReader (response.GetResponseStream(), Encoding.Default); // streamreader olarak response dan d�nen de�eri okuyoruz
            //string oku = reader.ReadToEnd();
            //int baslangic = oku.IndexOf("<h1>MSN Status Checker</h1>"); // ba�lang�� veriyorum
            //int son = oku.LastIndexOf("<form method=\"POST\" action=\"/msn/stchecker\">");
            //string parse = oku.Substring(baslangic, son-baslangic); // okunacak de�eri belirliyorum
           
            //parse = parse.Replace("<h1>", "").Replace("</h1><br>", Environment.NewLine).Replace("<br><b>",
            //    Environment.NewLine).Replace("<b>", "").Replace("</b>", "").Replace("<br><br><br>", ""); 
            //Console.WriteLine(parse); // ekrana yazd�r
            //Console.ReadLine(); // ekran� dondur     

        }
    }
}