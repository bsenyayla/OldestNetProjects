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

    public class CompanyOrganizationTable {
        public string Name { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    public class ProdTable {
        public string ProdName { get; set; }
        public string ProdSoyad { get; set; }
        public int ProdYas { get; set; }
    }

    public partial class Form2 : Form {

        public Dictionary<uint, CompanyOrganizationTable> dicCompany = new Dictionary<uint, CompanyOrganizationTable>();
        IRedisClient memGlobal = new RedisClient();

        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            FillDictionary();
        }

        private void FillDictionary() {
            #region FillDictionary
            dicCompany.Add(1, new CompanyOrganizationTable() { Name = "1 Abdüş", Soyad = "opel", Yas = 4 });
            dicCompany.Add(2, new CompanyOrganizationTable() { Name = "2 bAHADIR", Soyad = "renu", Yas = 4 });
            dicCompany.Add(3, new CompanyOrganizationTable() { Name = "3 DİLEK", Soyad = "merso", Yas = 4 });
            dicCompany.Add(4, new CompanyOrganizationTable() { Name = "4 AVUKAT", Soyad = "toyota", Yas = 4 });
            dicCompany.Add(5, new CompanyOrganizationTable() { Name = "5 YATAK", Soyad = "sarı", Yas = 4 });
            dicCompany.Add(51, new CompanyOrganizationTable() { Name = "6 Abdüş", Soyad = "yeşil", Yas = 4 });
            dicCompany.Add(52, new CompanyOrganizationTable() { Name = "7 bAHADIR", Soyad = "kırmızı", Yas = 4 });
            dicCompany.Add(53, new CompanyOrganizationTable() { Name = "8 DİLEK", Soyad = "siyah", Yas = 4 });
            dicCompany.Add(54, new CompanyOrganizationTable() { Name = "9 AVUKAT", Soyad = "mavi", Yas = 4 });
            dicCompany.Add(55, new CompanyOrganizationTable() { Name = "10 YATAK", Soyad = "gri", Yas = 4 });
            dicCompany.Add(151, new CompanyOrganizationTable() { Name = "11 Abdüş", Soyad = "Bal", Yas = 4 });
            dicCompany.Add(152, new CompanyOrganizationTable() { Name = "12 bAHADIR", Soyad = "domates", Yas = 4 });
            dicCompany.Add(153, new CompanyOrganizationTable() { Name = "13 DİLEK", Soyad = "yeşil", Yas = 4 });
            dicCompany.Add(154, new CompanyOrganizationTable() { Name = "14 AVUKAT", Soyad = "bıyık", Yas = 4 });
            dicCompany.Add(155, new CompanyOrganizationTable() { Name = "15 YATAK", Soyad = "sakal", Yas = 4 });

            Dictionary<uint, ProdTable> dicProd = new Dictionary<uint, ProdTable>();
            dicProd.Add(3, new ProdTable() { ProdName = "DİLEK", ProdSoyad = "Kuraz", ProdYas = 4 });
            dicProd.Add(4, new ProdTable() { ProdName = "AVUKAT", ProdSoyad = "Kurna", ProdYas = 4 });
            dicProd.Add(5, new ProdTable() { ProdName = "YATAK", ProdSoyad = "Kurnaz", ProdYas = 4 });

            #endregion FillDictionary
            memGlobal.FlushDb();

            GFillDataListToCache("XCompany", dicCompany);
            //FillDataListToCache("XCompany", dicCompany);



            Dictionary<uint, CompanyOrganizationTable> dicYeniCompany = new Dictionary<uint, CompanyOrganizationTable>();
            //GGetDataListFromCache("XCompany", ref dicYeniCompany);
            GetDataListFromCache("XCompany", ref dicYeniCompany);


            #region ROld
            return;
            Dictionary<string, CompanyOrganizationTable> dicSingleCompany = new Dictionary<string, CompanyOrganizationTable>();
            dicSingleCompany.Add("253", new CompanyOrganizationTable() { Name = "13 DİLEK", Soyad = "Salyut", Yas = 4 });
            dicSingleCompany.Add("254", new CompanyOrganizationTable() { Name = "14 AVUKAT", Soyad = "Tefal", Yas = 4 });
            dicSingleCompany.Add("255", new CompanyOrganizationTable() { Name = "15 YATAK", Soyad = "Dove", Yas = 4 });
            foreach (var vlSing in dicSingleCompany) {
                GAddOrSetCache(vlSing.Key, "XCompany", vlSing.Value);
                //AddOrSetCache(vlSing.Key, "XCompany", vlSing.Value);
            }

            Dictionary<string, CompanyOrganizationTable> dicCacheCompany = new Dictionary<string, CompanyOrganizationTable>();
            foreach (string vlSing in new string[] { "55", "151", "253" }) {
                //CompanyOrganizationTable tmpObj = GetCache("XCompany:" + vlSing);
                CompanyOrganizationTable tmpObj = GGetCache<CompanyOrganizationTable>("XCompany:" + vlSing);
                dicCacheCompany.Add(vlSing, tmpObj);
            }

            //generic methodlar ===============================================
            #endregion ROld
            string sttt = "";
        }


        private void GetDataListFromCache<K>(string vlCacheKey, ref Dictionary<K, CompanyOrganizationTable> vlDic) {
            //Çalışıyor
            //var getSpecificKeys = memGlobal.SearchKeys(vlCacheKey + "*");

            //var tmpData = memGlobal.GetAll<CompanyOrganizationTable>(getSpecificKeys).ToDictionary(
            //        k => k.Key.ToString().Split(':')[1], 
            //        v => v.Value
            //    );

            //foreach (var vl in tmpData) {
            //    K ob1 = vl.Key;
            //    CompanyOrganizationTable ob2 = vl.Value;

            //    Type typeParameterType = typeof(K);
            //    //System.UInt32

                

            //    vlDic.Add(ob1, new CompanyOrganizationTable());
            //}


            //vlDic = (Dictionary<uint, CompanyOrganizationTable>)tmpData;

            string ff = "";
        }


        //Toplu olarak dictionary listeyi cache yazma
        private void FillDataListToCache(string vlCacheKey, Dictionary<uint, CompanyOrganizationTable> vlDic) {
            //Çalışıyor
            var vl = vlDic.ToDictionary(k => $"{vlCacheKey}:" + k.Key.ToString(), v => v.Value);
            memGlobal.SetAll(vlDic.ToDictionary(k => $"{vlCacheKey}:" + k.Key.ToString(), v => v.Value));
        }



        private T GGetCache<T>(string vlKey) {
            /*dictionry değiş iiçindeki , değeri vereceksin*/
            var obj = memGlobal.Get<T>(vlKey);
            return obj;
        }

        private void GAddOrSetCache<T>(string vlKey, T vlData) {
            //Çalışıyor
            memGlobal.Set<T>(vlKey, vlData);
        }

        private void GAddOrSetCache<T>(string vlKey, string vlListName, T vlData) {
            //Çalışıyor
            GAddOrSetCache(vlListName + ":" + vlKey, vlData);
        }



        private void GGetDataListFromCache<T>(string vlCacheKey, ref Dictionary<string, T> vlDic) {
            //Çalışıyor
            var getSpecificKeys = memGlobal.SearchKeys(vlCacheKey + "*");
            var tmpData = memGlobal.GetAll<T>(getSpecificKeys);

            foreach (var vl in tmpData) {

                Object ob1 = vl.Key.ToString();
                T ob2 = vl.Value;
            }
            vlDic = (Dictionary<string, T>)tmpData;

            string ff = "";
        }


        private void GFillDataListToCache<T>(string vlCacheKey, Dictionary<uint, T> vlDic) {
            //Çalışıyor
            var vl = vlDic.ToDictionary(k => $"{vlCacheKey}:" + k.Key.ToString(), v => v.Value);
            memGlobal.SetAll(vlDic.ToDictionary(k => $"{vlCacheKey}:" + k.Key.ToString(), v => v.Value));
        }



        #region SabitMethodLar



        private CompanyOrganizationTable GetCache(string vlKey) {
            //Çalışıyor
            var obj = memGlobal.Get<CompanyOrganizationTable>(vlKey);
            return obj;
        }

        private void AddOrSetCache(string vlKey, string vlListName, CompanyOrganizationTable vlData) {
            //Çalışıyor
            AddOrSetCache(vlListName + ":" + vlKey, vlData);
        }


        private void AddOrSetCache(string vlKey, CompanyOrganizationTable vlData) {
            //Çalışıyor
            memGlobal.Set<CompanyOrganizationTable>(vlKey, vlData);
        }

        //Toplu olarak dictionary listeyi cache den alma

        #endregion SabitMethodLar
    }

}
