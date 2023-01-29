using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceMirasAlma
{
/*
    class BaseClass
    {

    }

    class DerivedClass:BaseClass { 


    }
*/

    class Ucak {
        public int Uzunluk;
        public int Yukseklik;
        public int Agirlik;
        protected int ServisKodu;

        public void TeknikBilgiGoster() {
            Console.WriteLine("Uzunluk:" + Uzunluk.ToString());
            Console.WriteLine("Yukseklik:" + Yukseklik.ToString());
            Console.WriteLine("Ağırlık:" + Agirlik.ToString());
        }
    }

    class AirBus : Ucak {
        public string Model;
        

        public void ModelGoster() {
            Console.WriteLine("Ucak modeli {0}",Model);
        }
    }

    class Boeing : Ucak {
        public string Model;

        public void ModelGoster()
        {
            Console.WriteLine("Ucak modeli {0}", Model);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AirBus A340 = new AirBus();
            A340.Model = "Airbus 340";
            A340.Uzunluk = 10;
            A340.Yukseklik = 34;
            A340.Agirlik = 458;
            

            A340.TeknikBilgiGoster();
            Console.ReadLine();

        }
    }
}
