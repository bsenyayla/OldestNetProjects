using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace S_Virtual
{
    internal class Program
    {
        private delegate void Temsilci(string strVal);
        //Tanımladığımız bu delege, geriye dönüş tipi void olan ve parametre almayan metotların adreslerini saklayabilir.

        [STAThread]
        public static void Main()
        {
            Temsilci t = new Temsilci(DelegateMethod);
            t.Invoke("hacı bekir");

            MyClass fnMyClass = new MyClass();
            fnMyClass.MyAutoImplementedProperty = 5;

            fnMyClass.MyProperty = 9;

            Console.WriteLine("AutoProperty:{0}",fnMyClass.MyAutoImplementedProperty);

            string sdf=Console.ReadLine();
            Console.Read();
        }



        private static void DelegateMethod(string strVal)
        {
            Console.WriteLine("Delegate method çalıştı. Gelen parametre :{0}", strVal);
        }

        private static void Test()
        {
            Console.WriteLine("Metot çalıştı ");
        }

    }
}