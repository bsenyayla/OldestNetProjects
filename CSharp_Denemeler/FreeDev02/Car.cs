using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDev02
{
    internal class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }


        public void Drive(){
            Console.WriteLine( "{0} colored, car is driving",this.Color);
        }
    }
}



