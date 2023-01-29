using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceApp.Abstract_ {
    public class dbBase:dbAbstract {
        public override void Run() {
            MessageBox.Show("dbBase");
        }
    }
}
