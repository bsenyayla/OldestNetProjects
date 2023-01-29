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
    public partial class TestFrm : Form {
        public Dictionary<uint, CompanyOrganizationTable> dicCompany = new Dictionary<uint, CompanyOrganizationTable>();
        IRedisClient memGlobal = new RedisClient();
        string cacheListName = "product";
        public TestFrm() {
            InitializeComponent();
        }
        private void GFillDataListToCache<K, V>(string vlCacheKey, Dictionary<K, V> vlDic) {
            var vl = vlDic.ToDictionary(k => $"{vlCacheKey}:" + k.Key.ToString(), v => v.Value);
            memGlobal.SetAll(vlDic.ToDictionary(k => $"{vlCacheKey}:" + k.Key.ToString(), v => v.Value));
        }
        private void TestFrm_Load(object sender, EventArgs e) {
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


            memGlobal.FlushDb();
            GFillDataListToCache(cacheListName, dicCompany);

            FillDictionary();
        }
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

        public class Keys {

            public string CACHEKEY_DNMSApplication { get; set; } 

            public const string AACACHEKEY_DNMSApplication = "DNMSApp";
            public const string CACHEKEY_AllProductClassWeb = "AllProductClassWeb";
            public const string CACHEKEY_AllProducts = "AllProducts";
            public const string CACHEKEY_AllProductClassBrand = "AllProductClassBrand";
            public const string CACHEKEY_AllCompanyOrganizations = "AllCompanyOrganizations";
            public const string CACHEKEY_AllBusinessLines = "AllBusinessLines";
            public const string CACHEKEY_UserGeneric = "UserGeneric_{0}";
            public const string CACHEKEY_UserRetailer = "UserRetailer_{0}";
            public const string CACHEKEY_AllProductUnitConversions = "AllProductUnitConversions";
            public const string CACHEKEY_AllProductBusinessLineRelations = "ProductBusinessLineRelations";
            public const string CACHEKEY_AllProductImages = "AllProductImages";
            public const string CACHEKEY_AllProductUnitDefinitions = "AllProductUnitDefinitions";
            public const string CACHEKEY_AllProductUnitGroups = "AllProductUnitGroups";
            public const string CACHEKEY_AllPrices = "AllPrices";
            public const string CACHEKEY_AllProductMixedCaseLines = "AllProductMixedCaseLines";
            public const string CACHEKEY_AllDistributorGroups = "AllDistributorGroups";
            public const string CACHEKEY_AllDistributors = "AllDistributors";
            public const string CACHEKEY_AllDistributorLocations = "AllDistributorLocations";
            public const string CACHEKEY_AllDistributorRouteGroups = "AllDistributorRouteGroups";
            public const string CACHEKEY_AllWarehouseLocations = "AllWarehouseLocations";
            public const string CACHEKEY_AllRetailerPromotionalGroups = "AllRetailerPromotionalGroups";
            public const string CACHEKEY_AllDistributorRouteGroups_v2 = "AllDistributorRouteGroups_v2";
            public const string CACHEKEY_AllRetailerPromotionalGroups_v2 = "AllRetailerPromotionalGroups_v2";
        }



        private void TestClas(Keys strVl) {
            MessageBox.Show(strVl.ToString());
        }


        private void FillDictionary() {

            TestClas(Keys.AACACHEKEY_DNMSApplication);


            Dictionary<uint, CompanyOrganizationTable> dicCache = new Dictionary<uint, CompanyOrganizationTable>();

            
            Dictionary<string, CompanyOrganizationTable> dicYeniCompany = new Dictionary<string, CompanyOrganizationTable>();
            
            GGetDataListFromCache<string,CompanyOrganizationTable>(cacheListName, ref dicYeniCompany);

            gridControl1.DataSource = dicYeniCompany;
        }

        private void GGetDataListFromCache<K,T>(string vlCacheKey, ref Dictionary<K, T> vlDic) {
            //Çalışıyor
            var getSpecificKeys = memGlobal.SearchKeys(vlCacheKey + "*");
            var tmpData = memGlobal.GetAll<T>(getSpecificKeys).Select(kk=>  
                new {
                        Key= kk.Key.Replace(vlCacheKey + ":",""),
                        Value=kk.Value
                }
            );


            Dictionary<K, T> vlDicc = (Dictionary<K, T>)tmpData;

            foreach (var vl in tmpData) {
                Object ob1 = vl.Key.ToString();
                T ob2 = vl.Value;

                vlDic.Add(
                        GetVal<K>(vl.Key)
                    , vl.Value
                    );
            }

            
        }

        private T GetVal<T>(object obj) {
            return (T)Convert.ChangeType(obj, typeof(T));
        }






    }

}