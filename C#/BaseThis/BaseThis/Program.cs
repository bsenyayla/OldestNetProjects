using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseThis
{
    class Program
    {

        class A1 {
            protected void AdinNe() {
                Console.WriteLine("Adınız nedir..");
            }

            private void Helluri()
            {

                this.AdinNe();
            }

            public void A1PublicMethodRun() {
                Console.WriteLine("A1 Public Method");
            }
        }

        class A2:A1
        {
            public void YasinKac()
            {
                base.AdinNe();
                Console.WriteLine("Yaşınız kaç..");
                
            }

        }

        class A3:A2
        {
            public void MeslekNedir()
            {
                base.YasinKac();
                Console.WriteLine("mesleğiniz nedir..");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Çalışıyorumm...");
            A3 ccA3 = new A3();
            ccA3.MeslekNedir();

            
            A1 ccA1 = new A1();
            
            Console.ReadLine();

        }
    }
}
