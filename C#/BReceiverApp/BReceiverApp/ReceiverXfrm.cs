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
using System.Threading;
using System.Diagnostics;

namespace BReceiverApp {
    public partial class ReceiverXfrm : DevExpress.XtraEditors.XtraForm {
        private static int receiverPort = 28000;
        private string receiverIp = "10.141.122.238";
        List<Thread> tList = new List<Thread>();
        List<ReceiveGridDataType> globalDataList = new List<ReceiveGridDataType>();
        TcpListener server = null;
        Thread tServer = null;
        bool _stop = false;


        public delegate void MyDelegeHandler2(int a,int b);
        //Geri dönüş tipi olmayan ve int tipinden iki adet parametre alan metodlar için kullanılır.

        public delegate int MyDelegeHandler3(int a,int b);
        //Geri dönüş tipi int olan ve int tipinden iki adet parametre alan metodlar için kullanılır.

        public delegate string MyDelegeHandler4();
        //Geri dönüş tipi string olan ve parametre almayan metodlar için kullanılır.

        public delegate void SetTextDelegaHander();


        public void XXX() {
            MessageBox.Show("d");
        }


        public void SetInfoText(String str) {
            if (InvokeRequired) {
                this.Invoke(new Action<string>(SetInfoText), new object[] { str });
                return;
            }

            SetTextDelegaHander delege = new SetTextDelegaHander(XXX);
            delege();


            outputTxt.EditValue += str;
            //ext.Insert(outputTxt.SelectionStart+1, str );



            gridMain.BeginUpdate();
            gridMain.DataSource = globalDataList;
            gridMain.EndUpdate();
        }

        public class ReceiveGridDataType {
            public String JsonData { get; set; }
            public DateTime RecieveDate { get; set; }
            public String ProgramId { get; set; }
        }



        void SetText(string str) {
            
            //outputTxt.Text += str + Environment.NewLine;
        }


        public void Server(string ip, int port) {
            IPAddress localAddr = IPAddress.Parse(ip);
            server = new TcpListener(localAddr, port);
            server.Start();
            StartListener();
        }

        public ReceiverXfrm() {
            InitializeComponent();
        }

        public void StartListener() {
            try {
                while (!_stop) {

                    SetInfoText("Waiting for a connection...");
                    TcpClient client = server.AcceptTcpClient();
                    if (_stop == true) {
                        client.Close();
                        break;
                    }

                    tList.Add(new Thread(new ParameterizedThreadStart(HandleDeivce)));
                    tList[tList.Count - 1].Start(client);

                    SetInfoText("Connected! port" + ((System.Net.IPEndPoint)(client.Client.RemoteEndPoint)).Port.ToString());

                }
            }
            catch (SocketException e) {
                SetInfoText("SocketException: " + e);
                server.Stop();
            }
        }

        public void HandleDeivce(Object obj) {
            if (_stop == true) {
                return;
            }

            TcpClient client = (TcpClient)obj;
            var stream = client.GetStream();
            string imei = String.Empty;
            string data = null;
            Byte[] bytes = new Byte[256];
            int i;
            try {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0) {
                    string hex = BitConverter.ToString(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, i);

                    globalDataList.Add(new ReceiveGridDataType {
                        JsonData = data,
                        RecieveDate = DateTime.Now,
                        ProgramId = ((System.Net.IPEndPoint)(client.Client.RemoteEndPoint)).Port.ToString()
                    });

                    SetInfoText("AppId:" + ((System.Net.IPEndPoint)(client.Client.RemoteEndPoint)).Port.ToString() + "JsonData:" + data);
                }
            }
            catch (Exception e) {
                SetInfoText("Exception: " + e.ToString());
                client.Close();
            }
        }

        private void ReceiverXfrm_Load(object sender, EventArgs e) {
            receiverIp = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();

            tServer = new Thread(delegate() {
                Server(receiverIp, receiverPort);
            });
            tServer.Name = "XXXServer";
            tServer.Start();
        }

        private void ReceiverXfrm_FormClosing(object sender, FormClosingEventArgs e) {
            _stop = true;
            foreach (Thread th in tList) {
                th.Abort();
            }
            tServer.IsBackground = true;
            tServer.DisableComObjectEagerCleanup();
            this.Visible = false;
            bgWorker.RunWorkerAsync();
            this.Dispose();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            tServer.Abort();
        }

    }
}