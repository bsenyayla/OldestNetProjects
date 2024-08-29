using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDev02.VirtualSample
{
    public  class Animal
    {

        public virtual void MakeSound() {
            Console.WriteLine("Animal makes a sound..");
        }
    }
}
