using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;


namespace MemCached {
    public partial class Form1 : Form {
        MemcachedClient client = null;

        public Form1() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            SetConfig();
        }

        void SetConfig() {
            MemcachedClientConfiguration config = new MemcachedClientConfiguration();
            config.AddServer("127.0.0.1", 11211);
            config.Protocol = MemcachedProtocol.Binary;
            client = new MemcachedClient(config);
        }

        [Serializable]
        class Person {
            public string Name { get; set; }
            public int Age { get; set; }
        }


        private void btnConfig_Click(object sender, EventArgs e) {

            

            bool result = client.Store(StoreMode.Set, "S01", new Person {
                Name = "Session 001",
                Age = 27
            });
        }

        private void btnRead_Click(object sender, EventArgs e) {
            Person retVal = (Person)client.Get("S01");

            MessageBox.Show(retVal.Name);

        }

        private void btnRemove_Click(object sender, EventArgs e) {

            ServerStats tt = client.Stats();
            


            string dfdg = "";
            //key verilip silinir
            //bool result = client.Remove("kisi");
            //TryGet
            //FlushAll
            //StoreMode.

            //client.
        }

        private void btnGetActiveCache_Click(object sender, EventArgs e) {
            
        }

        private void btnReadConfig_Click(object sender, EventArgs e) {
            String str=            ConfigurationManager.AppSettings["Cache"];

            String sdfsf = "";

        }

        EskiKod fn = new EskiKod();

        private void MySqlDataWrite(string strThread) {
            AppendTextBox(Environment.NewLine + strThread );

            DateTime start = DateTime.Now;
            // Do some work
            Int32 vlCount = Convert.ToInt32( txtCount.Text);
            for (Int32 i = 0; i < vlCount; i++) {

                fn.WriteToProduct();
            }
            TimeSpan timeDiff = DateTime.Now - start;


            AppendTextBox(Environment.NewLine + "Toplam Satır: " + vlCount.ToString());
            AppendTextBox(Environment.NewLine + "Zaman: " + timeDiff.TotalSeconds.ToString() + " Saniye");


        }

        public void AppendTextBox(string value) {
            if (InvokeRequired) {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtAck.AppendText(value);
        }

        private void btnWriteMySql_Click(object sender, EventArgs e) {

            Thread tlonger = new Thread(CountLonger);
            tlonger.Start();

            Thread tshorter = new Thread(CountLonger);
            tshorter.Start();


            //workerMySqlWrite.RunWorkerAsync();

            //backgroundWorker1.RunWorkerAsync();
            //backgroundWorker2.RunWorkerAsync();
        }

        public void CountLonger() {
            MySqlDataWrite("TH => 1");
        }

        private void workerMySqlWrite_DoWork(object sender, DoWorkEventArgs e) {
            MySqlDataWrite("thread 1");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            MySqlDataWrite("thread 2");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) {
            MySqlDataWrite("thread 3");
        }
    }
}
