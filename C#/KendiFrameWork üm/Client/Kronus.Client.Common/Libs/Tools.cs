using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kronus.Client.Common.Libs
{
    public class Tools
    {
        [Serializable]
        private class UserSetting
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }
        static List<UserSetting> UserSettingList = new List<UserSetting>();

        public static string GetIp()
        {
            string ip = "";
            if (ip == null)
            {
                string myHost = System.Net.Dns.GetHostName();
                ip = System.Net.Dns.GetHostEntry(myHost).AddressList[0].ToString();
            }
            return ip;
        }

        public static string DomainName() {
            return "bsenyayla";
        }
        //public static void SetKullanici(Personel value)
        //{
        //    //kullanici = value;
        //    //yetkiler = Biz.SecurtiyProvider.GetYetkisByPersonelId(kullanici.Id);
        //}


        //public static Personel GetKullanici()
        //{
        //    if (kullanici == null)
        //    {
        //        kullanici = Biz.PersonProvider.GetPersonInfo(WindowsIdentity.GetCurrent().Name.Replace(@"SPEAK\", ""));
        //        yetkiler = Biz.SecurtiyProvider.GetYetkisByPersonelId(kullanici.Id);
        //    }
        //    return kullanici;
        //}

        public static string GetBaslik()
        {
            return "NaviMAXX v" + Application.ProductVersion;
        }

        //public static bool ValiteForm(List<ErrorValidator.IErrorValidator> errorValidators, DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider)
        //{

        //    bool isFormClean = true;

        //    errorProvider.ClearErrors();

        //    foreach (ErrorValidator.IErrorValidator errorValidator in errorValidators)
        //    {
        //        ErrorValidator.ValidationResult result = errorValidator.Validate();
        //        if (result.Result == false)
        //        {
        //            errorProvider.SetError(errorValidator.FormControl, result.Text);
        //            errorProvider.SetIconAlignment(errorValidator.FormControl, ErrorIconAlignment.TopRight);
        //            isFormClean = false;

        //        }
        //    }

        //    return isFormClean;
        //}

        public static string GetDateString(DateTime tarih)
        {
            return tarih.ToShortDateString() + " " + tarih.ToShortTimeString();
        }


        public static void ShowInfoMessageBox(string mesaj)
        {
            MessageBox.Show(mesaj, GetBaslik(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorMessageBox(string mesaj)
        {
            MessageBox.Show(mesaj, GetBaslik(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        //public static bool CheckYetki(Guid yetkiId)
        //{
        //    if (yetkiler == null || yetkiler.Count == 0) return false;

        //    return (yetkiler.Count(p => p.Id == yetkiId) > 0);
        //}






        public static void AddAyar(string key, string deger)
        {
            //KullaniciAyar kullaniciAyar = (from a in GetKullaniciAyars() where a.Key == key select a).FirstOrDefault();
            if (UserSettingList.Count == 0)
            {
                UserSettingList.Add(new UserSetting { Key = key, Value = deger });
            }
            else
            {
                for (int i = 0; i < UserSettingList.Count; i++)
                {
                    if (UserSettingList[i].Key == key)
                    {
                        UserSettingList[i].Value = deger;
                    }
                }
            }
            SaveSettings();
        }

        //public static KullaniciAyar GetKullaniciAyar(string key)
        //{
        //    var result = (from a in GetKullaniciAyars() where a.Key == key select a).FirstOrDefault();
        //    return result;
        //}

        //public static List<KullaniciAyar> GetKullaniciAyars() 
        //{
        //    if (kullaniciAyarlar == null)
        //    {
        //        try
        //        {
        //            LoadSettings();
        //        }
        //        catch (Exception ex)
        //        {
        //            kullaniciAyarlar = new List<KullaniciAyar>();
        //            SaveSettings();
        //        }
        //    }

        //    return kullaniciAyarlar;
        //}

        private static void SaveSettings()
        {
            try
            {
                string file = System.IO.Path.Combine(Application.StartupPath, "UserSettings.spk");
                Stream fs = new FileStream(file, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, UserSettingList);
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string GetSetting(string Key)
        {
            LoadSettings();
            UserSetting vlSetting = UserSettingList.Where(x => x.Key == Key).SingleOrDefault();
            return vlSetting.Value;
        }

        private static void LoadSettings()
        {
            string file = System.IO.Path.Combine(Application.StartupPath, "UserSettings.spk");

            if (!System.IO.File.Exists(file))
            {
                throw new Exception("Ayar dosyası bulunamadı.");
            }

            Stream fs = new FileStream(file, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            UserSettingList = bf.Deserialize(fs) as List<UserSetting>;
            fs.Close();
        }


    }
}
