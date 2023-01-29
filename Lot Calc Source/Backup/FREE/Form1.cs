using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;

namespace FREE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllWebPageFrm frm = new AllWebPageFrm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LotCalc frm = new LotCalc();
            //frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            richEditControl1.SaveDocument("c:\\cc.rtf", DocumentFormat.Rtf);
            //richEditControl1.LoadDocument()
            
        }
    }
}