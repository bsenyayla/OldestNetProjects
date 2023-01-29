using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{

    /*
     Protected örneği
     */
    class AccClass_1 {

        public  string Run() {
            return SubRun();
        }

        protected string SubRun() {
            return "SubRun Class1";
        }


        internal string RunInternal()
        {
            return "Run İnternal Class1";
        }

    
     }

     class AccClass_2 {
         public string Run()
         {
             return SubRun();
         }

         protected string SubRun()
         {
             return "SubRun Class2";
         }


         public void AccessAnotherClass() {

             AccClass_1  cc= new AccClass_1();
             //--cc.SubRun buraya ulaşamazsınız Protected ile oluşturulmuş class lara ancak kendi class ından ulaşabilirsiniziz


             
         }
     }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışıyorum....");
            AccClass_1 fn = new AccClass_1();


            fn.
            Console.WriteLine(fn.Run());


            Console.ReadLine();
        }
    }
}
