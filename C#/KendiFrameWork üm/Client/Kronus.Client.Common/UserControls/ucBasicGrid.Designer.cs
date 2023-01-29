namespace Kronus.Client.Common.UserControls {
    partial class ucBasicGrid {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXLSX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXLS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRTF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMHT = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.contextMenuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.contextMenuGrid;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 0);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(582, 252);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.DoubleClick += new System.EventHandler(this.gridMain_DoubleClick);
            // 
            // contextMenuGrid
            // 
            this.contextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.contextMenuAktar,
            this.bilgiToolStripMenuItem});
            this.contextMenuGrid.Name = "contextMenuGrid";
            this.contextMenuGrid.Size = new System.Drawing.Size(153, 92);
            this.contextMenuGrid.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuGrid_Opening);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Kronus.Client.Common.Properties.Resources.refresh_16x16;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Yenile";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // contextMenuAktar
            // 
            this.contextMenuAktar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemXLSX,
            this.toolStripMenuItemXLS,
            this.toolStripMenuItemCSV,
            this.toolStripMenuItemPDF,
            this.toolStripMenuItemRTF,
            this.toolStripMenuItemTXT,
            this.toolStripMenuItemMHT});
            this.contextMenuAktar.Image = global::Kronus.Client.Common.Properties.Resources.export_16x16;
            this.contextMenuAktar.Name = "contextMenuAktar";
            this.contextMenuAktar.Size = new System.Drawing.Size(152, 22);
            this.contextMenuAktar.Text = "Aktar";
            // 
            // toolStripMenuItemXLSX
            // 
            this.toolStripMenuItemXLSX.Image = global::Kronus.Client.Common.Properties.Resources.exporttoxlsx_16x16;
            this.toolStripMenuItemXLSX.Name = "toolStripMenuItemXLSX";
            this.toolStripMenuItemXLSX.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemXLSX.Text = "Excel (xlsx)";
            this.toolStripMenuItemXLSX.ToolTipText = "YeniExcel Dosya formatı xlsx";
            this.toolStripMenuItemXLSX.Click += new System.EventHandler(this.toolStripMenuItemXLSX_Click);
            // 
            // toolStripMenuItemXLS
            // 
            this.toolStripMenuItemXLS.Image = global::Kronus.Client.Common.Properties.Resources.exporttoxls_16x16;
            this.toolStripMenuItemXLS.Name = "toolStripMenuItemXLS";
            this.toolStripMenuItemXLS.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemXLS.Text = "Excel (Eski xls)";
            this.toolStripMenuItemXLS.ToolTipText = "eski excel Formatı";
            this.toolStripMenuItemXLS.Click += new System.EventHandler(this.toolStripMenuItemXLS_Click);
            // 
            // toolStripMenuItemCSV
            // 
            this.toolStripMenuItemCSV.Image = global::Kronus.Client.Common.Properties.Resources.exporttocsv_16x16;
            this.toolStripMenuItemCSV.Name = "toolStripMenuItemCSV";
            this.toolStripMenuItemCSV.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemCSV.Text = "CSV";
            this.toolStripMenuItemCSV.ToolTipText = "comma-separated values";
            this.toolStripMenuItemCSV.Click += new System.EventHandler(this.toolStripMenuItemCSV_Click);
            // 
            // toolStripMenuItemPDF
            // 
            this.toolStripMenuItemPDF.Image = global::Kronus.Client.Common.Properties.Resources.exporttopdf_16x16;
            this.toolStripMenuItemPDF.Name = "toolStripMenuItemPDF";
            this.toolStripMenuItemPDF.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemPDF.Text = "Pdf";
            this.toolStripMenuItemPDF.ToolTipText = "PDF, Taşınabilir Belge Biçimi";
            this.toolStripMenuItemPDF.Click += new System.EventHandler(this.toolStripMenuItemPDF_Click);
            // 
            // toolStripMenuItemRTF
            // 
            this.toolStripMenuItemRTF.Image = global::Kronus.Client.Common.Properties.Resources.exporttortf_16x16;
            this.toolStripMenuItemRTF.Name = "toolStripMenuItemRTF";
            this.toolStripMenuItemRTF.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemRTF.Text = "Rtf";
            this.toolStripMenuItemRTF.ToolTipText = "Zengin Dosya Biçimi";
            this.toolStripMenuItemRTF.Click += new System.EventHandler(this.toolStripMenuItemRTF_Click);
            // 
            // toolStripMenuItemTXT
            // 
            this.toolStripMenuItemTXT.Image = global::Kronus.Client.Common.Properties.Resources.exporttotxt_16x16;
            this.toolStripMenuItemTXT.Name = "toolStripMenuItemTXT";
            this.toolStripMenuItemTXT.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemTXT.Text = "Txt";
            this.toolStripMenuItemTXT.ToolTipText = "Text , düz yazı formatı";
            this.toolStripMenuItemTXT.Click += new System.EventHandler(this.toolStripMenuItemTXT_Click);
            // 
            // toolStripMenuItemMHT
            // 
            this.toolStripMenuItemMHT.Image = global::Kronus.Client.Common.Properties.Resources.exporttomht_16x16;
            this.toolStripMenuItemMHT.Name = "toolStripMenuItemMHT";
            this.toolStripMenuItemMHT.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemMHT.Text = "Mht";
            this.toolStripMenuItemMHT.ToolTipText = "Sıkıştırılmış web dosyası";
            this.toolStripMenuItemMHT.Click += new System.EventHandler(this.toolStripMenuItemMHT_Click);
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.bilgiToolStripMenuItem_Click);
            // 
            // gridMainView
            // 
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            // 
            // ucBasicGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridMain);
            this.Name = "ucBasicGrid";
            this.Size = new System.Drawing.Size(582, 252);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.contextMenuGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem contextMenuAktar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMHT;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPDF;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXLSX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXLS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTF;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTXT;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
    }
}
