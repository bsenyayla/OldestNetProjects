namespace Kronus.Client.Destop.Crm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.Industrial2of5Generator ındustrial2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Industrial2of5Generator();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            this.label1 = new System.Windows.Forms.Label();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.popupGalleryEdit1 = new DevExpress.XtraEditors.PopupGalleryEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.breadCrumbEdit1 = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.mruEdit1 = new DevExpress.XtraEditors.MRUEdit();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.tokenEdit1 = new DevExpress.XtraEditors.TokenEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.ucWait1 = new Kronus.Client.Common.UserControls.ucWait();
            ((System.ComponentModel.ISupportInitialize)(this.popupGalleryEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crm ekranı";
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Location = new System.Drawing.Point(300, 1);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(125, 48);
            this.barCodeControl1.Symbology = ındustrial2of5Generator1;
            this.barCodeControl1.TabIndex = 3;
            // 
            // popupGalleryEdit1
            // 
            this.popupGalleryEdit1.Location = new System.Drawing.Point(300, 110);
            this.popupGalleryEdit1.Name = "popupGalleryEdit1";
            this.popupGalleryEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupGalleryEdit1.Size = new System.Drawing.Size(148, 20);
            this.popupGalleryEdit1.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(182, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 5;
            // 
            // breadCrumbEdit1
            // 
            this.breadCrumbEdit1.Location = new System.Drawing.Point(300, 82);
            this.breadCrumbEdit1.Name = "breadCrumbEdit1";
            this.breadCrumbEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode1.Value = "Root";
            this.breadCrumbEdit1.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1});
            this.breadCrumbEdit1.Properties.ReadOnly = false;
            this.breadCrumbEdit1.Properties.SelectedNode = breadCrumbNode1;
            this.breadCrumbEdit1.Size = new System.Drawing.Size(251, 22);
            this.breadCrumbEdit1.TabIndex = 6;
            // 
            // mruEdit1
            // 
            this.mruEdit1.Location = new System.Drawing.Point(300, 136);
            this.mruEdit1.Name = "mruEdit1";
            this.mruEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruEdit1.Size = new System.Drawing.Size(152, 20);
            this.mruEdit1.TabIndex = 7;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(300, 56);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(214, 20);
            this.searchControl1.TabIndex = 8;
            // 
            // tokenEdit1
            // 
            this.tokenEdit1.Location = new System.Drawing.Point(51, 268);
            this.tokenEdit1.Name = "tokenEdit1";
            this.tokenEdit1.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEdit1.Size = new System.Drawing.Size(100, 20);
            this.tokenEdit1.TabIndex = 9;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(51, 295);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 10;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(300, 162);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(318, 252);
            this.pdfViewer1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucWait1
            // 
            this.ucWait1.Location = new System.Drawing.Point(51, 203);
            this.ucWait1.Name = "ucWait1";
            this.ucWait1.Size = new System.Drawing.Size(164, 34);
            this.ucWait1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 426);
            this.Controls.Add(this.ucWait1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.breadCrumbEdit1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.tokenEdit1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.mruEdit1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.popupGalleryEdit1);
            this.Controls.Add(this.barCodeControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.popupGalleryEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraEditors.PopupGalleryEdit popupGalleryEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.BreadCrumbEdit breadCrumbEdit1;
        private DevExpress.XtraEditors.MRUEdit mruEdit1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.TokenEdit tokenEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button button1;
        private Common.UserControls.ucWait ucWait1;
    }
}