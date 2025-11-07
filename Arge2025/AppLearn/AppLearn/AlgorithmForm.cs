using AppLearn.AlgorithmExamples;
using AppLearn.AlgoTmp;

using Microsoft.Web.WebView2.Core;
using static AppLearn.Common.Tools;

namespace AppLearn
{
    public partial class AlgorithmForm : Form
    {
        public AlgorithmForm()
        {
            InitializeComponent();
        }

        private void btn_ReverseStringWay1_Click(object sender, EventArgs e)
        {
            AlgorithmExamples.ReverseStringWay1 fn1 = new AlgorithmExamples.ReverseStringWay1(this.resultBox);

            fn1.ReverseString(input2.Text);
            fn1.ReverseStringWithFor(input2.Text);
            fn1.StringSort(input1.Text.ToLower());

            Msg(this.resultBox, "Module:2%2 " + 2 % 2);

            int x = 3;
            Msg(this.resultBox, "Module:2%2 " + (x ^= 3));
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.Show();

        }

        private void btn_DublicateNumbersInArray_Click(object sender, EventArgs e)
        {
            AlgorithmExamples.FindDuplicateNumbersInArray fn1 = new AlgorithmExamples.FindDuplicateNumbersInArray(this.resultBox);

            fn1.Way1_Linq(new int[] { 1, 2, 3, 4, 2, 5, 3, 6, 7, 1 });
            fn1.Way2_HashTable(new int[] { 1, 2, 3, 4, 2, 5, 3, 6, 7, 1 });
            fn1.Way3_OnO1(new int[] { 7, 0, 7 });
        }

        private void btn_Palindrome_Click(object sender, EventArgs e)
        {
            AlgorithmExamples.Palindrome fn1 = new Palindrome(this.resultBox);
            fn1.Way1(input1.Text);
            fn1.Way2(input1.Text);
            fn1.Way3_WithStack(input1.Text);
        }

        private void btnSolidLiskov_Click(object sender, EventArgs e)
        {
            Solid_O.Ostrich cls1 = new Solid_O.Ostrich();
            cls1.Fly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgoTmp.AlgoQ1 tt = new AlgoTmp.AlgoQ1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlgoTmp.AlgoQ2_TwoSum gg = new AlgoTmp.AlgoQ2_TwoSum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlgoTmp.AlgoQ3_ValidParentheses gg = new AlgoTmp.AlgoQ3_ValidParentheses();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlgoQ4_ReverseString gg = new AlgoQ4_ReverseString(); 
        }
    }
}
