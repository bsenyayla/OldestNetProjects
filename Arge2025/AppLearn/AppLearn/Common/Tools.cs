using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.Common
{
    public static class Tools
    {


        public static void Msg(TextBox refTextBox,string messageString)
        {
            refTextBox.Text += messageString + Environment.NewLine;
            Console.WriteLine(messageString);
        }
    }
}
