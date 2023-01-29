using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S_Virtual
{
    public class MyClass
    {
        public string myField = string.Empty;

        public MyClass()
        {
            Console.WriteLine("class construction çalıştı..");
        }

        public void MyMethod(int prm1, int prm2)
        {
            Console.WriteLine("First parameter {0} , second parameter {1}", prm1, prm2);
        }

        public int MyAutoImplementedProperty { get; set; }

        private int myPropertyValue;

        public int MyProperty
        {
            get { return myPropertyValue; }
            set { myPropertyValue = value; }
        }



    }
}