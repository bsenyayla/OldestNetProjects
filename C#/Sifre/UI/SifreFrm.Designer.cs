namespace UI
{
    partial class SifreFrm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreFrm));
            this.btnMd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifrelenmis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCozulmus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMd
            // 
            this.btnMd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMd.Location = new System.Drawing.Point(620, 329);
            this.btnMd.Name = "btnMd";
            this.btnMd.Size = new System.Drawing.Size(122, 23);
            this.btnMd.TabIndex = 0;
            this.btnMd.Text = "Şifrele / Çöz";
            this.btnMd.UseVisualStyleBackColor = true;
            this.btnMd.Click += new System.EventHandler(this.btnMd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // txtPure
            // 
            this.txtPure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPure.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPure.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPure.Location = new System.Drawing.Point(92, 2);
            this.txtPure.Multiline = true;
            this.txtPure.Name = "txtPure";
            this.txtPure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPure.Size = new System.Drawing.Size(649, 103);
            this.txtPure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifrelenmiş Text";
            // 
            // txtSifrelenmis
            // 
            this.txtSifrelenmis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSifrelenmis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifrelenmis.Location = new System.Drawing.Point(92, 111);
            this.txtSifrelenmis.Multiline = true;
            this.txtSifrelenmis.Name = "txtSifrelenmis";
            this.txtSifrelenmis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSifrelenmis.Size = new System.Drawing.Size(650, 103);
            this.txtSifrelenmis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çözülmüş Text";
            // 
            // txtCozulmus
            // 
            this.txtCozulmus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCozulmus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCozulmus.Location = new System.Drawing.Point(92, 220);
            this.txtCozulmus.Multiline = true;
            this.txtCozulmus.Name = "txtCozulmus";
            this.txtCozulmus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCozulmus.Size = new System.Drawing.Size(650, 103);
            this.txtCozulmus.TabIndex = 7;
            // 
            // SifreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCozulmus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifrelenmis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPure);
            this.Controls.Add(this.btnMd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SifreFrm";
            this.Text = "SifreFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifrelenmis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCozulmus;
    }
}