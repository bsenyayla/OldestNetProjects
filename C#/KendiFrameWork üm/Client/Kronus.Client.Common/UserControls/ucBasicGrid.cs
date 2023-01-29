using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronus.Client.Common.UserControls {
    public partial class ucBasicGrid : UserControl {

        public event EventHandler GridDoubleClick;

        public ucBasicGrid() {
            InitializeComponent();
        }

        public object DataSource {
            get { return null; }
            set {
                gridMain.DataSource = value;

                if (value != null)
                {
                    int sayi = gridMainView.Columns.Count;
                    for (int ii = 0; ii < sayi; ii++)
                    {
                        if (gridMainView.Columns[ii].Name.Contains("Id"))
                        {
                            gridMainView.Columns[ii].Visible = false;
                        }
                    }

                    gridMainView.BestFitColumns();
                }
            }
        }

        public object GetFocusedRow {
            get {
                return gridMainView.GetFocusedRow();
            }
        }

        private void gridMain_DoubleClick(object sender, EventArgs e)
        {
            if (this.GridDoubleClick != null)
                this.GridDoubleClick(this, e);   
        }

        private void contextMenuGrid_Opening(object sender, CancelEventArgs e) {
            //gridControl1.ex
        }

        private void Export(string FileType) {
            SaveFileDialog dialog = new SaveFileDialog() {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            dialog.ShowDialog();

            if (dialog.FileName == "") { return; }
            string folderPath = dialog.FileName;


            switch (FileType) {
                case "XLSX":
                    gridMain.ExportToXlsx(folderPath + ".xlsx");
                break;

                case "XLS":
                    gridMain.ExportToXls(folderPath + ".xlsx");
                break;

                case "CSV":
                    gridMain.ExportToCsv(folderPath + ".csv");
                break;

                case "PDF":
                    gridMain.ExportToPdf(folderPath + ".pdf");
                break;

                case "RTF":
                    gridMain.ExportToRtf(folderPath + ".rtf");
                break;

                case "TXT":
                    gridMain.ExportToText(folderPath + ".txt");
                break;

                case "MHT":
                    gridMain.ExportToMht(folderPath + ".mht");
                break;
            }
        }

        private void toolStripMenuItemXLSX_Click(object sender, EventArgs e) {
            Export("XLSX");
        }

        private void toolStripMenuItemXLS_Click(object sender, EventArgs e) {
            Export("XLS");
        }

        private void toolStripMenuItemCSV_Click(object sender, EventArgs e) {
            Export("CSV");
        }

        private void toolStripMenuItemPDF_Click(object sender, EventArgs e) {
            Export("PDF");
        }

        private void toolStripMenuItemRTF_Click(object sender, EventArgs e) {
            Export("RTF");
        }

        private void toolStripMenuItemTXT_Click(object sender, EventArgs e) {
            Export("TXT");
        }

        private void toolStripMenuItemMHT_Click(object sender, EventArgs e) {
            Export("MHT");
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gridInfo = "GridName:" + gridMain.Name.ToString() + "\n GridViewName :" + gridMain.MainView.Name.ToString();

            MessageBox.Show(gridInfo);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        
        }
        
        

    }
}
