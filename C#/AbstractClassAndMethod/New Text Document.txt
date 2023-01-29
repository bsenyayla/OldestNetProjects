using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public abstract class Kisi {
        public string AdSoyad;

        public abstract string Meslek
        {
            get;
        }

        public virtual void Yaz()
        {
            Console.WriteLine("Adı Soyadı:" + AdSoyad);
            Console.WriteLine("Mesleği:" + Meslek);
        }
    }

    public class Ogrenci : Kisi {
        public int Sinif;
        public override string Meslek {
            get
            {
                return "Öğrenci";
            }
        }

        public override void Yaz()
        {
            //base.Yaz();
            Console.WriteLine("Adı Soyadı:" + AdSoyad);
            Console.WriteLine("Mesleği:" + Meslek);
            Console.WriteLine("Sınıf:" + this.Sinif.ToString());
        }

    }

    public class Ogretmen : Kisi {
        public string Brans;

        public override string Meslek
        {
            get
            {
                return "Öğretmen";
            }
        }

        public override void Yaz()
        {
            //base.Yaz();
            Console.WriteLine("Adı Soyadı:" + AdSoyad);
            Console.WriteLine("Mesleği:" + Meslek);
            Console.WriteLine("Branşı:" + Brans);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışıyor..");
            Ogrenci fn = new Ogrenci();
            fn.Sinif = 3;
            fn.AdSoyad = "hacı bekir";
            Console.WriteLine(fn.Meslek);
            fn.Yaz();


            Console.WriteLine("========================================");
            Ogretmen fnOgretmen = new Ogretmen();
            fnOgretmen.AdSoyad = "Junior Bush";
            fnOgretmen.Brans = "Devlet Yönetimi";
            fnOgretmen.Yaz();
            Console.ReadLine();
        }
    }
}
