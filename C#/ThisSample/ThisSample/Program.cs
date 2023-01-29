using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisSample
{
    class A1 {
        public A1() {
            Console.WriteLine("A1 constructor çalıştı...");
        }

        public A1(string x)
        {
            Console.WriteLine(x +  "A1  çalıştı ,tek parametre ");
        }
    }

    class A2:A1 {
        public A2() : base()
        {

        }

        public A2(string x) : base(x) 
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışıyor...");
            A2 a2c = new A2();
            A2 a2d = new A2("hello");

            Console.ReadLine();
        }
    }
}
