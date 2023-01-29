namespace DelegateApp {
    partial class BaseForm {
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
            this.btnButon_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButon_1
            // 
            this.btnButon_1.Location = new System.Drawing.Point(83, 216);
            this.btnButon_1.Name = "btnButon_1";
            this.btnButon_1.Size = new System.Drawing.Size(129, 23);
            this.btnButon_1.TabIndex = 0;
            this.btnButon_1.Text = "Tıkla Form İsmini Vereyim";
            this.btnButon_1.UseVisualStyleBackColor = true;
            this.btnButon_1.Click += new System.EventHandler(this.btnButon_1_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnButon_1);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButon_1;
    }
}

