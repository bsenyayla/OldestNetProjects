using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDev02.VirtualSample
{
    public class Horse : Animal
    {
        public Horse()
        {
        }

        public override void MakeSound()
        {
            //base.MakeSound();
            Utils.Msg("ben bir at im... ");
        }
    }
}
