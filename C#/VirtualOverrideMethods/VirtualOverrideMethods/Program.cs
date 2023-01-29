using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideMethods
{

    class ParaYatirma {

        public ParaYatirma(){
            Console.WriteLine("Public base construction");
        }

        public virtual void ParaCekmeTemel() {
            Console.WriteLine("Base temel para yatırma çekme methodu..");
        }
    }


    class Havale:ParaYatirma {
        
        public override void ParaCekmeTemel()
        {
            Console.WriteLine("Miras aLan .havale methodu para yatırma çekme fonksiyonu");
        }
    }

    class EFT:ParaYatirma {
        public override void ParaCekmeTemel()
        {
            Console.WriteLine("Miras aLan .EFT methodu para yatırma çekme fonksiyonu");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışıyorum....");


            ParaYatirma py = new ParaYatirma();
            Havale havale = new Havale();
            EFT eft = new EFT();

            ParaYatirma pyReferans;
            pyReferans = py;
            pyReferans.ParaCekmeTemel();


            pyReferans = havale;
            pyReferans.ParaCekmeTemel();


            pyReferans = eft;
            pyReferans.ParaCekmeTemel();
            //Havale fnHavale = new Havale();
            //fnHavale.ParaCekmeTemel();

            Console.ReadLine();
        }
    }
}
