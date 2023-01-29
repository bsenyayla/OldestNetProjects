namespace FREE
{
    partial class AllWebPageFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIsYatirim = new System.Windows.Forms.TabPage();
            this.tabPageGaranti = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPageIsYatirim.SuspendLayout();
            this.tabPageGaranti.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIsYatirim);
            this.tabControl1.Controls.Add(this.tabPageGaranti);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageIsYatirim
            // 
            this.tabPageIsYatirim.Controls.Add(this.webBrowser1);
            this.tabPageIsYatirim.Location = new System.Drawing.Point(4, 22);
            this.tabPageIsYatirim.Name = "tabPageIsYatirim";
            this.tabPageIsYatirim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIsYatirim.Size = new System.Drawing.Size(856, 600);
            this.tabPageIsYatirim.TabIndex = 0;
            this.tabPageIsYatirim.Text = "Ýþ Yatýrým";
            this.tabPageIsYatirim.UseVisualStyleBackColor = true;
            // 
            // tabPageGaranti
            // 
            this.tabPageGaranti.Controls.Add(this.webBrowser2);
            this.tabPageGaranti.Location = new System.Drawing.Point(4, 22);
            this.tabPageGaranti.Name = "tabPageGaranti";
            this.tabPageGaranti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGaranti.Size = new System.Drawing.Size(856, 600);
            this.tabPageGaranti.TabIndex = 1;
            this.tabPageGaranti.Text = "Garanti";
            this.tabPageGaranti.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(850, 594);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.isyatirim.com.tr/C_LT_companycard.aspx", System.UriKind.Absolute);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(850, 594);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("http://report.paragaranti.com/rasyonet_fiyatbilgileri.asp?Hisse=GARAN", System.UriKind.Absolute);
            // 
            // AllWebPageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "AllWebPageFrm";
            this.Text = "AllWebPageFrm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIsYatirim.ResumeLayout(false);
            this.tabPageGaranti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageIsYatirim;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPageGaranti;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}