namespace Kronus.Client.Destop.Srv
{
    partial class TestFormEdit
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBody)).BeginInit();
            this.groupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFooter
            // 
            this.groupFooter.Location = new System.Drawing.Point(5, 178);
            this.groupFooter.Size = new System.Drawing.Size(540, 55);
            // 
            // groupBody
            // 
            this.groupBody.Controls.Add(this.button1);
            this.groupBody.Size = new System.Drawing.Size(540, 168);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 143;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestFormEdit
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 238);
            this.Name = "TestFormEdit";
            this.Text = "TestFormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.groupFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBody)).EndInit();
            this.groupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}