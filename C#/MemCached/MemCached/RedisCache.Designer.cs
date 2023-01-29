namespace MemCached {
    partial class RedisCache {
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnOtherMeth = new System.Windows.Forms.Button();
            this.btnDirectObj = new System.Windows.Forms.Button();
            this.btnSingleObject = new System.Windows.Forms.Button();
            this.btnDbSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(109, 200);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(97, 25);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtSet
            // 
            this.txtSet.Location = new System.Drawing.Point(8, 30);
            this.txtSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSet.Multiline = true;
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(189, 150);
            this.txtSet.TabIndex = 1;
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(207, 30);
            this.txtGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGet.Multiline = true;
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(189, 150);
            this.txtGet.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(8, 200);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(97, 25);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnOtherMeth
            // 
            this.btnOtherMeth.Location = new System.Drawing.Point(8, 247);
            this.btnOtherMeth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOtherMeth.Name = "btnOtherMeth";
            this.btnOtherMeth.Size = new System.Drawing.Size(102, 25);
            this.btnOtherMeth.TabIndex = 4;
            this.btnOtherMeth.Text = "Other Method";
            this.btnOtherMeth.UseVisualStyleBackColor = true;
            // 
            // btnDirectObj
            // 
            this.btnDirectObj.Location = new System.Drawing.Point(301, 200);
            this.btnDirectObj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDirectObj.Name = "btnDirectObj";
            this.btnDirectObj.Size = new System.Drawing.Size(124, 25);
            this.btnDirectObj.TabIndex = 5;
            this.btnDirectObj.Text = "Direct Object";
            this.btnDirectObj.UseVisualStyleBackColor = true;
            this.btnDirectObj.Click += new System.EventHandler(this.btnDirectObj_Click);
            // 
            // btnSingleObject
            // 
            this.btnSingleObject.Location = new System.Drawing.Point(301, 229);
            this.btnSingleObject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSingleObject.Name = "btnSingleObject";
            this.btnSingleObject.Size = new System.Drawing.Size(124, 25);
            this.btnSingleObject.TabIndex = 6;
            this.btnSingleObject.Text = "Direct Single Object\r\n";
            this.btnSingleObject.UseVisualStyleBackColor = true;
            this.btnSingleObject.Click += new System.EventHandler(this.btnSingleObject_Click);
            // 
            // btnDbSil
            // 
            this.btnDbSil.Location = new System.Drawing.Point(460, 200);
            this.btnDbSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbSil.Name = "btnDbSil";
            this.btnDbSil.Size = new System.Drawing.Size(97, 25);
            this.btnDbSil.TabIndex = 7;
            this.btnDbSil.Text = "Db Sil";
            this.btnDbSil.UseVisualStyleBackColor = true;
            this.btnDbSil.Click += new System.EventHandler(this.btnDbSil_Click);
            // 
            // RedisCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 292);
            this.Controls.Add(this.btnDbSil);
            this.Controls.Add(this.btnSingleObject);
            this.Controls.Add(this.btnDirectObj);
            this.Controls.Add(this.btnOtherMeth);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.txtSet);
            this.Controls.Add(this.btnGet);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RedisCache";
            this.Text = "RedisCache";
            this.Load += new System.EventHandler(this.RedisCache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnOtherMeth;
        private System.Windows.Forms.Button btnDirectObj;
        private System.Windows.Forms.Button btnSingleObject;
        private System.Windows.Forms.Button btnDbSil;
    }
}