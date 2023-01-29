namespace UI
{
    partial class ExceptionFrm
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
            this.btnException = new System.Windows.Forms.Button();
            this.btnPgSql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(12, 226);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(75, 23);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "Exception";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // btnPgSql
            // 
            this.btnPgSql.Location = new System.Drawing.Point(131, 226);
            this.btnPgSql.Name = "btnPgSql";
            this.btnPgSql.Size = new System.Drawing.Size(75, 23);
            this.btnPgSql.TabIndex = 1;
            this.btnPgSql.Text = "PgSql";
            this.btnPgSql.UseVisualStyleBackColor = true;
            this.btnPgSql.Click += new System.EventHandler(this.btnPgSql_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.btnPgSql);
            this.Controls.Add(this.btnException);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnException;
        private System.Windows.Forms.Button btnPgSql;
    }
}

