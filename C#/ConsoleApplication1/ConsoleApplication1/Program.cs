using System.Collections;
using System.Data;
 using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApplication1 {
    class Program {
        private static readonly string _queueName = "BSENYAYLA_RabbitMQ";
        private static Publisher _publisher;
        static void Main(string[] args) {


            Console.WriteLine("Program Çalışıyor...");

            // string tipinde 3 elemanli bir dizi olusturalim
            // Örnek generic sınıf a örnek olarak List tipini verebiliriz
            string[] strArray = { "Ahmet", "Mehmet", "Ali" };

            ArrayList strArrayList = new ArrayList();
            strArrayList.Add("Ahmet");
            strArrayList.Add("Mehmet");
            strArrayList.Add("Ali");
            strArrayList.Add("Ayşe");
            strArrayList.Add(3);

            foreach (object obj in strArrayList) {
                Console.WriteLine(obj.ToString());
            }

            //Kendimize örnek bir Generic class tanımlayalım

            SonucObj<DataTable> retVal = new SonucObj<DataTable>();
            retVal.Basarili = true;
            retVal.Mesaj = "Başarılı";
            retVal.Data = new DataTable("Table_1");



            eventLogSubscription();

            //
            //_publisher = new Publisher(_queueName, "Hello RabbitMQ World!");
            RabbitMQ_NewTask();


            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8090/");
            listener.Start();

            while (true) {
                HttpListenerContext ctx = listener.GetContext();
                ThreadPool.QueueUserWorkItem((_) => {


                    string dfgdf = ctx.Request.Url.ToString();


                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes("<HTML><BODY> helluri</BODY></HTML>");
                    // Get a response stream and write the response to it.
                    ctx.Response.ContentLength64 = buffer.Length;
                    System.IO.Stream output = ctx.Response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    output.Close();

                    #region UrlParams
                    //string methodName = ctx.Request.Url.Segments[1].Replace("/", "");
                    //string[] strParams = ctx.Request.Url
                    //                        .Segments
                    //                        .Skip(2)
                    //                        .Select(s => s.Replace("/", ""))
                    //                        .ToArray();
                    //var method = ctx.GetType().GetMethod(methodName);
                    //object[] @params = method.GetParameters()
                    //                    .Select((p, i) => Convert.ChangeType(strParams[i], p.ParameterType))
                    //                    .ToArray();
                    //object ret = method.Invoke(ctx, @params);
                    //string retstr = JsonConvert.SerializeObject(ret);
                    #endregion UrlParams
                });

            }


            
            //
            //Bekleme while ı ---------------------------------------------------------------------------
            do {
                Console.ReadLine();
            } while (1 == 1);

        }

        public static void RabbitMQ_NewTask() {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("== Rabbit MQ ===================================================================================================");


            Person person = new Person() { Name = "Bora", SurName = "Kasmer", ID = 1, BirthDate = new DateTime(1978, 6, 3), Message = "İlgili aday yakınımdır :)" };

            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel()) {
                channel.QueueDeclare(queue: "Borsoft",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = JsonConvert.SerializeObject(person);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "Borsoft",
                                     basicProperties: null,
                                     body: body);
            }

            Console.WriteLine(" İlgili kişi gönderildi...");
            Console.WriteLine("Yeni RabbitMQ oluşturuldu !!!! ");
        }

        class OrnekClassType {
            string Ad { get; set; }
            string Soyad { get; set; }
        }

        public class Person {
            public int ID { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Message { get; set; }
        }

        //==========================================================================================================================
        #region EventTrace
        private void StartWatch() {
            EventLog myLog = new EventLog(watchLog);

            // set event handler
            myLog.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten);
            myLog.EnableRaisingEvents = true;
        }

        private void OnEntryWritten(object source, EntryWrittenEventArgs e) {
            string logName = watchLog;
            GetLogEntryStats(watchLog);

            if (logType == eventFilter || eventFilter.Length == 0) {
                // show balloon
                NotifyIcon.ShowBalloon("Event Log Monitor",
                  "An event was written to the " + logName + " event log." +
                  "\nType: " + LogType +
                  "\nSource: " + LogSource +
                  "\nCategory: " + LogCategory +
                  "\nEventID: " + EventID +
                  "\nUser: " + User,
                  NotifyIconEx.NotifyInfoFlags.Info,
                  5000);

                LogNotification();
            }
        }

        private void GetLogEntryStats(string logName) {
            int e = 0;

            EventLog log = new EventLog(logName);
            e = log.Entries.Count - 1; // last entry

            logMessage = log.Entries[e].Message;
            logMachine = log.Entries[e].MachineName;
            logSource = log.Entries[e].Source;
            logCategory = log.Entries[e].Category;
            logType = Convert.ToString(log.Entries[e].EntryType);
            eventID = log.Entries[e].EventID.ToString();
            user = log.Entries[e].UserName;
            logTime = log.Entries[e].TimeGenerated.ToShortTimeString();
            log.Close();  // close log
        }

        #endregion EventTrace
        //==========================================================================================================================
    }
}