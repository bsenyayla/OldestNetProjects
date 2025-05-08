using AppLearn.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLearn
{
    public partial class LinqFrm : Form
    {
        private TextBox _resultBox;
        
        public LinqFrm(TextBox resultBox)
        {
            InitializeComponent();
            _resultBox = resultBox;
        }

        private void btnAggregat_Click(object sender, EventArgs e)
        {
            LINQ.FirstSample fn1 = new LINQ.FirstSample(this._resultBox);
            fn1.Aggregate();

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            try
            {
                LINQ.FirstSample fn1 = new LINQ.FirstSample(this._resultBox);
                fn1.WhereUsage();

                fn1.GroupByUsage();

                fn1.InnerJoinUsage();
                Common.Tools.Msg(_resultBox, "Try-");
                // Hata olabilecek kod buraya yazılır
            }
            catch (CustomException cex)
            {

                Common.Tools.Msg(_resultBox, "catch-Hata yakalanır ve burada işlenir");
                // Hata yakalanır ve burada işlenir
            }
            catch (Exception ex) { 
            
            }
            finally
            {
                Common.Tools.Msg(_resultBox, "Finally - Hata olsa da olmasa da her durumda çalışır");
                // Hata olsa da olmasa da her durumda çalışır
            }


        }
    }
}


