using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDev02.VirtualSample
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            //base.MakeSound();
            Console.WriteLine("Virtual Override... ve ben bir kopegim");
        }
    }
}
