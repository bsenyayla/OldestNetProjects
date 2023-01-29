using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {

        public static void Method(int a) {
            Console.WriteLine("Tek parametre girildi ve 1. method çalıştı");
        }

        public static void Method(int a, int b) {
            Console.WriteLine("iki parametre girildi ve 2. method çalıştı");
        }

        public static void Method(double a, double b)
        {
            Console.WriteLine("iki parametre girildi ve 3. method çalıştı");
        }

        public static void Method(string a, string b)
        {
            Console.WriteLine("iki parametre girildi ve 4. method çalıştı");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Çalışıyor...");
            Program.Method(1);
            Program.Method(1,3);
            Program.Method(1.4,5.6);
            Program.Method("sdf","f");
            Console.ReadLine();
        }
    }
}
