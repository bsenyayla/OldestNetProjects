namespace Kronus.Client.Common.Management {
    partial class AppGeneralInfo {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtWorkingFolder = new DevExpress.XtraEditors.MemoEdit();
            this.btnDownloadApi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkingFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Working Folder";
            // 
            // txtWorkingFolder
            // 
            this.txtWorkingFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingFolder.Location = new System.Drawing.Point(105, 19);
            this.txtWorkingFolder.Name = "txtWorkingFolder";
            this.txtWorkingFolder.Size = new System.Drawing.Size(277, 212);
            this.txtWorkingFolder.TabIndex = 1;
            this.txtWorkingFolder.UseOptimizedRendering = true;
            // 
            // btnDownloadApi
            // 
            this.btnDownloadApi.Image = global::Kronus.Client.Common.Properties.Resources.exporttopdf_32x32;
            this.btnDownloadApi.Location = new System.Drawing.Point(265, 243);
            this.btnDownloadApi.Name = "btnDownloadApi";
            this.btnDownloadApi.Size = new System.Drawing.Size(117, 23);
            this.btnDownloadApi.TabIndex = 2;
            this.btnDownloadApi.Text = "Download Api";
            this.btnDownloadApi.Click += new System.EventHandler(this.btnDownloadApi_Click);
            // 
            // AppGeneralInfo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 278);
            this.Controls.Add(this.btnDownloadApi);
            this.Controls.Add(this.txtWorkingFolder);
            this.Controls.Add(this.labelControl1);
            this.Name = "AppGeneralInfo";
            this.Text = "AppGeneralInfoForm1";
            this.Load += new System.EventHandler(this.AppGeneralInfoForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkingFolder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtWorkingFolder;
        private DevExpress.XtraEditors.SimpleButton btnDownloadApi;
    }
}