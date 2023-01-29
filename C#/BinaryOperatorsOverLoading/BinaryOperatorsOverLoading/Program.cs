using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryOperatorsOverLoading
{
    class BinaryOverloadSample {
        private int x;
        private int y;

        public BinaryOverloadSample() : this(0, 0) { 
        
        }

        public BinaryOverloadSample(int a, int b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return (x + "," + y);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışıyorum....");

            BinaryOverloadSample fn = new BinaryOverloadSample();

            Console.WriteLine(fn.ToString());

            Console.ReadLine();
        }
    }
}
