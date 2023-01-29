namespace Kronus.Client.Common.Forms
{
    partial class BaseXtraListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseXtraListForm));
            this.ListeGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new Kronus.Client.Common.UserControls.ucBasicGrid();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.FiltreGroupControl = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ListeGroupControl)).BeginInit();
            this.ListeGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiltreGroupControl)).BeginInit();
            this.FiltreGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeGroupControl
            // 
            this.ListeGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeGroupControl.Controls.Add(this.gridMain);
            this.ListeGroupControl.Location = new System.Drawing.Point(5, 109);
            this.ListeGroupControl.Name = "ListeGroupControl";
            this.ListeGroupControl.Size = new System.Drawing.Size(663, 289);
            this.ListeGroupControl.TabIndex = 7;
            this.ListeGroupControl.Text = "Liste";
            // 
            // gridMain
            // 
            this.gridMain.DataSource = null;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(659, 266);
            this.gridMain.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnYenile.Location = new System.Drawing.Point(489, 28);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(81, 24);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(576, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 24);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FiltreGroupControl
            // 
            this.FiltreGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltreGroupControl.Controls.Add(this.btnYenile);
            this.FiltreGroupControl.Controls.Add(this.btnKapat);
            this.FiltreGroupControl.Location = new System.Drawing.Point(5, 5);
            this.FiltreGroupControl.Name = "FiltreGroupControl";
            this.FiltreGroupControl.Size = new System.Drawing.Size(663, 98);
            this.FiltreGroupControl.TabIndex = 6;
            this.FiltreGroupControl.Text = "Arama Kriterleri";
            // 
            // BaseXtraListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 402);
            this.Controls.Add(this.ListeGroupControl);
            this.Controls.Add(this.FiltreGroupControl);
            this.Name = "BaseXtraListForm";
            this.Text = "BaseXtraListForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListeGroupControl)).EndInit();
            this.ListeGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FiltreGroupControl)).EndInit();
            this.FiltreGroupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.GroupControl ListeGroupControl;
        protected DevExpress.XtraEditors.GroupControl FiltreGroupControl;

        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnKapat;

        private UserControls.ucBasicGrid gridMain;
    }
}