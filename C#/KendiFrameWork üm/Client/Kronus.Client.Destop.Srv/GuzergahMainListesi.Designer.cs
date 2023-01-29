namespace Kronus.Client.Destop.Srv
{
    partial class GuzergahMainListesi
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new Kronus.Client.Common.UserControls.ucBasicGrid();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edt_lkpProje = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpDurum = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_lkpTip = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnYeniGuzergahMain = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_lkpProje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_lkpTip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gridMain);
            this.groupControl2.Location = new System.Drawing.Point(6, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(909, 278);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Liste";
            // 
            // gridMain
            // 
            this.gridMain.DataSource = null;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(905, 255);
            this.gridMain.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(417, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Durum";
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnYenile.Location = new System.Drawing.Point(674, 27);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(111, 25);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(792, 27);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(111, 25);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proje Adı";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnYeniGuzergahMain);
            this.groupControl1.Controls.Add(this.edt_lkpTip);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.edt_lkpProje);
            this.groupControl1.Controls.Add(this.lkpDurum);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(6, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(909, 66);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Arama Kriterleri";
            // 
            // edt_lkpProje
            // 
            this.edt_lkpProje.Location = new System.Drawing.Point(57, 30);
            this.edt_lkpProje.Name = "edt_lkpProje";
            this.edt_lkpProje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_lkpProje.Properties.NullText = "";
            this.edt_lkpProje.Size = new System.Drawing.Size(155, 20);
            this.edt_lkpProje.TabIndex = 62;
            // 
            // lkpDurum
            // 
            this.lkpDurum.EditValue = "";
            this.lkpDurum.Location = new System.Drawing.Point(463, 30);
            this.lkpDurum.Name = "lkpDurum";
            this.lkpDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpDurum.Properties.NullText = "Seçiniz...";
            this.lkpDurum.Size = new System.Drawing.Size(76, 20);
            this.lkpDurum.TabIndex = 15;
            // 
            // edt_lkpTip
            // 
            this.edt_lkpTip.EditValue = "";
            this.edt_lkpTip.Location = new System.Drawing.Point(280, 30);
            this.edt_lkpTip.Name = "edt_lkpTip";
            this.edt_lkpTip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_lkpTip.Properties.NullText = "Seçiniz...";
            this.edt_lkpTip.Size = new System.Drawing.Size(117, 20);
            this.edt_lkpTip.TabIndex = 64;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(230, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Proje Tipi";
            // 
            // btnYeniGuzergahMain
            // 
            this.btnYeniGuzergahMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniGuzergahMain.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnYeniGuzergahMain.Location = new System.Drawing.Point(557, 27);
            this.btnYeniGuzergahMain.Name = "btnYeniGuzergahMain";
            this.btnYeniGuzergahMain.Size = new System.Drawing.Size(111, 25);
            this.btnYeniGuzergahMain.TabIndex = 65;
            this.btnYeniGuzergahMain.Text = "Yeni Güzergah";
            this.btnYeniGuzergahMain.Click += new System.EventHandler(this.btnYeniGuzergahMain_Click);
            // 
            // GuzergahMainListesi
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 361);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "GuzergahMainListesi";
            this.Text = "Ana Güzergah Listesi";
            this.Load += new System.EventHandler(this.GuzergahMainListesi_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.GuzergahMainListesi_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_lkpProje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_lkpTip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lkpDurum;
        private DevExpress.XtraEditors.LookUpEdit edt_lkpProje;
        private Common.UserControls.ucBasicGrid gridMain;
        private DevExpress.XtraEditors.LookUpEdit edt_lkpTip;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnYeniGuzergahMain;
    }
}