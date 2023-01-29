using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{

    class singleTon
    {
        private static singleTon _obje;


        private singleTon() { 
        
        }

        public static singleTon Obje() {

            if (_obje == null)
            {
                Console.WriteLine("Obje yaratılmamış şimdi yaratıyorum...");
                _obje = new singleTon();
            }
            else {
                Console.WriteLine("böyle bir obje yaratılmış...");
            }

            return _obje;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışıyor..");
            Console.ReadLine();

            singleTon a = singleTon.Obje();
            Console.ReadLine();
            singleTon b = singleTon.Obje();

            Console.ReadLine();
        }
    }
}
