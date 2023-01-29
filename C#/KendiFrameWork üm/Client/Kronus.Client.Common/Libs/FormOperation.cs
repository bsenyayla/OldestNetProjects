using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Kronus.Client.Common.Libs {
    public class FormOperation {
        Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
        List<Control> ctrlList = new List<Control>();

        public FormOperation() {
            dictionary.Add("DevExpress.XtraEditors.GroupControl", false);
            dictionary.Add("DevExpress.XtraEditors.LabelControl", false);
            dictionary.Add("DevExpress.XtraEditors.SimpleButton", false);
        }


        public void CleanForm(Form frm) {
            if (ctrlList.Count == 0) {
                GetControls(frm);
            }

            foreach (Control ctrl in ctrlList) {
                switch (ctrl.GetType().FullName) {
                    case "DevExpress.XtraEditors.LookUpEdit":
                    DevExpress.XtraEditors.LookUpEdit objL = ctrl as DevExpress.XtraEditors.LookUpEdit;
                    objL.EditValue = null;
                    break;

                    case "DevExpress.XtraEditors.TextEdit":
                    DevExpress.XtraEditors.TextEdit objE = ctrl as DevExpress.XtraEditors.TextEdit;
                    objE.EditValue = null;
                    break;

                    case "DevExpress.XtraEditors.CalcEdit":
                    DevExpress.XtraEditors.CalcEdit objC = ctrl as DevExpress.XtraEditors.CalcEdit;
                    objC.EditValue = null;
                    break;

                    case "DevExpress.XtraEditors.DateEdit":
                    DevExpress.XtraEditors.DateEdit objD = ctrl as DevExpress.XtraEditors.DateEdit;
                    objD.EditValue = null;
                    break;

                }
            }
            //DevExpress.XtraEditors.TextBoxMaskBox
            //DevExpress.XtraEditors.CheckEdit
            MessageBox.Show("bitti");
        }

        private void GetControls(Control vlCntrl) {
            foreach (Control inCtrl in vlCntrl.Controls) {
                if (inCtrl.Controls.Count > 1) {
                    GetControls(inCtrl);
                } else {
                    string iname = inCtrl.Name;
                    string ifullname = inCtrl.GetType().FullName;
                    
                    if (dictionary.ContainsKey(ifullname)) {
                        GetControls(inCtrl);
                    }

                    if (iname.StartsWith("edt_")) {
                        ctrlList.Add(inCtrl);
                    }
                }
            }
        }



    }
}
