namespace MemCached
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGetActiveCache = new System.Windows.Forms.Button();
            this.txtAck = new System.Windows.Forms.TextBox();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.workerMySqlWrite = new System.ComponentModel.BackgroundWorker();
            this.btnWriteMySql = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(12, 12);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(233, 37);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "MemCached Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 55);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(233, 37);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "MemCached Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 98);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(233, 37);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "MemCached - Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetActiveCache
            // 
            this.btnGetActiveCache.Location = new System.Drawing.Point(12, 401);
            this.btnGetActiveCache.Name = "btnGetActiveCache";
            this.btnGetActiveCache.Size = new System.Drawing.Size(233, 37);
            this.btnGetActiveCache.TabIndex = 3;
            this.btnGetActiveCache.Text = "Get Active Cache";
            this.btnGetActiveCache.UseVisualStyleBackColor = true;
            this.btnGetActiveCache.Click += new System.EventHandler(this.btnGetActiveCache_Click);
            // 
            // txtAck
            // 
            this.txtAck.Location = new System.Drawing.Point(364, 103);
            this.txtAck.Multiline = true;
            this.txtAck.Name = "txtAck";
            this.txtAck.Size = new System.Drawing.Size(543, 185);
            this.txtAck.TabIndex = 4;
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(674, 294);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(233, 37);
            this.btnReadConfig.TabIndex = 5;
            this.btnReadConfig.Text = "Read Config Full Settings";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // workerMySqlWrite
            // 
            this.workerMySqlWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerMySqlWrite_DoWork);
            // 
            // btnWriteMySql
            // 
            this.btnWriteMySql.Location = new System.Drawing.Point(344, 401);
            this.btnWriteMySql.Name = "btnWriteMySql";
            this.btnWriteMySql.Size = new System.Drawing.Size(233, 37);
            this.btnWriteMySql.TabIndex = 6;
            this.btnWriteMySql.Text = "Write To Mysql";
            this.btnWriteMySql.UseVisualStyleBackColor = true;
            this.btnWriteMySql.Click += new System.EventHandler(this.btnWriteMySql_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(433, 65);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(144, 28);
            this.txtCount.TabIndex = 7;
            this.txtCount.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Count";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnWriteMySql);
            this.Controls.Add(this.btnReadConfig);
            this.Controls.Add(this.txtAck);
            this.Controls.Add(this.btnGetActiveCache);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "MemCached";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGetActiveCache;
        private System.Windows.Forms.TextBox txtAck;
        private System.Windows.Forms.Button btnReadConfig;
        private System.ComponentModel.BackgroundWorker workerMySqlWrite;
        private System.Windows.Forms.Button btnWriteMySql;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

