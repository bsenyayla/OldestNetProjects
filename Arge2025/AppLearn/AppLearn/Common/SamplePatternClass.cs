using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppLearn.Common.Tools;

namespace AppLearn.Common
{
    public class SamplePatternClass
    {
        private TextBox _refTextBox;
        public SamplePatternClass(TextBox refText)
        {
            _refTextBox = refText;
            Msg(_refTextBox, " inherit class");
        }

        public void MsgTT(string message)
        {
            Msg(_refTextBox, message);
        }

    }
}


