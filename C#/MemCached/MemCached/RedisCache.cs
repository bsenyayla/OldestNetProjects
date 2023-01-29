using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemCached {
    public partial class RedisCache : Form {
        public RedisCache() {
            InitializeComponent();
        }

        private void RedisCache_Load(object sender, EventArgs e) {

        }

        //public static byte[] ToByteArray(this object obj) {
        //    var size = Marshal.SizeOf(data);
        //    var bytes = new byte[size];
        //    var ptr = Marshal.AllocHGlobal(size);
        //    Marshal.StructureToPtr(data, ptr, false);
        //    Marshal.Copy(ptr, bytes, 0, size);
        //    Marshal.FreeHGlobal(ptr);
        //    return bytes;
        //}

        //public static string Serialize(this object obj) {
        //    return JsonConvert.SerializeObject(obj);
        //}

        public static byte[] ConvertToBytes(object obj) {
            /*bu byte arry olarak alıyor bunu convert etmek lazım*/
            
            using (var ms = new MemoryStream()) {
                using (var writer = new BsonWriter(ms)) {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(writer, new { Value = obj });
                    return ms.ToArray();
                }
            }
        }

        private void btnGet_Click(object sender, EventArgs e) {
            // this usage is key and bytes
            using (IRedisNativeClient client = new RedisClient()) {
             


                client.Set("Mesaj:1", Encoding.UTF8.GetBytes("Hello World"));


                string result = Encoding.UTF8.GetString(client.Get("Mesaj:1"));


                txtGet.Text = result;
            }
        }

        private void btnSet_Click(object sender, EventArgs e) {

        }

        private void SadeceStingVeriIcin() {
            /*string kaullanımı için*/
            using (IRedisClient client = new RedisClient()) {
                var names = client.Lists["names"];
                names.Clear();

                names.Add("Murat");
                names.Add("Yadigar");
                names.Add("Serkan");
            }

            using (IRedisClient client = new RedisClient()) {
                var names = client.Lists["names"];

                foreach (var name in names) {
                    txtGet.AppendText($"İsim : {name}" + Environment.NewLine);

                }

            }
        }




        private void btnDirectObj_Click(object sender, EventArgs e) {

            //bizim için uygun olan obje ve tablo bazlı cache leme
            long lastCustomerId = 0;

            // SET
            using (IRedisClient client = new RedisClient()) {
                //IRedisTypedClient
                

                var customerClient = client.As<Customer>();

                var customer = new Customer() {
                    Id = 2,
                    Name = "Jess Lewis",
                    Orders = new List<Order>{
                        new Order() { Id = 1 },
                        new Order() { Id = 2 }
                    }
                };

                var savedCustomer = customerClient.Store(customer);


                var customer1 = new Customer() {
                    Id = 3,
                    Name = "Jess Lewis",
                    Orders = new List<Order>{
                        new Order() { Id = 1 },
                        new Order() { Id = 2 }
                    }
                };

                var savedCustomer1 = customerClient.Store(customer1);

                var customer2 = new Customer() {
                    Id = 237,
                    Name = "Bahadır Şenyayla",
                    Orders = new List<Order>{
                        new Order() { Id = 1 ,Name="Dove Şampuan"},
                        new Order() { Id = 2 }
                    }
                };

                var savedCustomer2 = customerClient.Store(customer2);


                lastCustomerId = savedCustomer.Id;
            }

            // GET
            using (IRedisClient client = new RedisClient("localhost", 6379)) {
                var customerClient = client.As<Customer>();
                var customer = customerClient.GetById(237);

                txtGet.AppendText($"Müşteri ismi : {customer.Name}\nMüşteri Id : {customer.Id}" + Environment.NewLine);
                
                txtGet.AppendText($"Ürün ismi : {customer.Orders[0].Name}" + Environment.NewLine);
            }
            

        }


        public class Customer {
            public long Id { get; set; }
            public string Name { get; set; }
            public List<Order> Orders { get; set; }
        }

        public class Order {
            public long Id { get; set; }
            public String Name { get; set; }
        }

        private void btnSingleObject_Click(object sender, EventArgs e) {
            
            long lastCustomerId = 0;

            // SET
            using (IRedisClient client = new RedisClient("localhost", 6379)) {
                //IRedisTypedClient

                client.Set<object>("WWW1",56);

                object obj= client.Get<object>("WWW1");


                txtGet.AppendText($"WWW1 : {obj.ToString()}" + Environment.NewLine);



            }


        }

        private void btnDbSil_Click(object sender, EventArgs e) {
            using (IRedisClient client = new RedisClient("localhost", 6379)) {
                client.FlushDb();
            }
        }




    }
}


//    public class Tmp {

//        var hashKey = "hashKey";

//        HashEntry[] redisBookHash = {
//    new HashEntry("title", "Redis for .NET Developers"),
//    new HashEntry("year", 2016),
//    new HashEntry("author", "Taswar Bhatti")
//  };

//        redis.HashSet(hashKey, redisBookHash);

//  if (redis.HashExists(hashKey, "year"))
//  {
//    var year = redis.HashGet(hashKey, "year"); //year is 2016
//    }

//    var allHash = redis.HashGetAll(hashKey);

//  //get all the items
//  foreach (var item in allHash)
//  {
//    //output 
//    //key: title, value: Redis for .NET Developers
//    //key: year, value: 2016
//    //key: author, value: Taswar Bhatti
//    Console.WriteLine(string.Format("key : {0}, value : {1}", item.Name, item.Value));
//  }

////get all the values
//var values = redis.HashValues(hashKey);

//  foreach (var val in values)
//  {
//    Console.WriteLine(val); //result = Redis for .NET Developers, 2016, Taswar Bhatti
//  }

//  //get all the keys
//  var keys = redis.HashKeys(hashKey);

//  foreach (var k in keys)
//  {
//    Console.WriteLine(k); //result = title, year, author
//  }

//  var len = redis.HashLength(hashKey);  //result of len is 3

//  if (redis.HashExists(hashKey, "year"))
//  {
//    var year = redis.HashIncrement(hashKey, "year", 1); //year now becomes 2017
//var year2 = redis.HashDecrement(hashKey, "year", 1.5); //year now becomes 2015.5
//  }