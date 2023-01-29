/*
 Bahadır Şenyayla
 bsenyayla@yahoo.com
 0535 552 73 92
 */
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
using Newtonsoft.Json;
using System.Collections;
using System.Net;
using System.Net.Sockets;

namespace ASenderApp {
    public partial class SenderXfrm : DevExpress.XtraEditors.XtraForm {

        private Socket senderObj = null;
        private int senderPort = 28000;
        private string senderIp = "10.141.122.238";
        private List<GridDataType> globalDataList = new List<GridDataType>();
        
         public class GridDataType {
            public String JsonData { get; set; }
            public DateTime SendDate { get; set; }
        }

        public SenderXfrm() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void SetControlProperty() {
            if (senderObj.Connected == true) {
                picStatus.BackColor = Color.Green;
                npMain.Text = "Bağlantı sağlandı";
                btnStart.Enabled = true;
                btnConnect.Enabled = false;
            }
            else {
                picStatus.BackColor = Color.Red;
                npMain.Text = "Bağlantı sağlanamadı...";
                btnConnect.Enabled = true;
            }
        }
        private void btnConnect_Click(object sender, EventArgs e) {
            try {
                senderIp = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
                senderObj = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                senderObj.Connect(new IPEndPoint(IPAddress.Parse(senderIp), senderPort));
            }

            catch (Exception ex) {

            }

            finally {
                SetControlProperty();
            }
        }

        private void SenderXfrm_Load(object sender, EventArgs e) {
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        private void mainTimer_Tick(object sender, EventArgs e) {
            CreateRandomData();
        }

        private void CreateRandomData() {
            if (senderObj.Connected == false) {
                mainTimer.Enabled = false;
                npMain.Text = "Bağlantı koptu...";
                btnStart.Enabled = false;
                btnConnect.Enabled = true;
                btnStop.Enabled = false;
                return;
            }
            
            Random rnd = new Random();
            DataType dataList = new DataType();
            dataList.Add = new Prm { PrmName = "Veri1", PrmType = "string", PrmValue = Common.Tools.GenerateString(4) }; 
            dataList.Add = new Prm { PrmName = "Veri2", PrmType = "int", PrmValue = rnd.Next(100).ToString()};
            dataList.Add = new Prm { PrmName = "Veri3", PrmType = "float", PrmValue = rnd.Next(100).ToString() };
            /*bu kısımda n tane yeni veri eklenebilir, verileri tipleride istediğimiz tipde olabilir .
             * Aynı şekilde receiver uygulamasıda bu değişiklikleri ,program üzerinde değişiklik yapmadan alabilir */
            string json2 = JsonConvert.SerializeObject(dataList);
            outputTxt.Text += json2 + Environment.NewLine;

            try {
                senderObj.Send(Encoding.UTF8.GetBytes(json2));
            }
            catch (Exception ex) {
                SetControlProperty();
                MessageBox.Show("bağlantı koptu.Dinleyici cevap vermiyor.");
                return;
            }
            globalDataList.Add(new GridDataType { JsonData = json2, SendDate = DateTime.Now  });
            RefreshGrid(globalDataList);
        }

        private void btnStart_Click(object sender, EventArgs e) {
            mainTimer.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }


        private void btnStop_Click(object sender, EventArgs e) {
            mainTimer.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void RefreshGrid(List<GridDataType> inPrm) {
            gridMain.BeginUpdate();
            gridMain.DataSource = inPrm;
            gridMain.EndUpdate();
        }

        private void SenderXfrm_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                if (senderObj != null) {
                    senderObj.Close();
                    senderObj.Dispose();
                }
            }
            catch (Exception ex) { 
            }
        }


    }
}