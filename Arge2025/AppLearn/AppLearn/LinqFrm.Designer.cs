namespace AppLearn
{
    partial class LinqFrm
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
            btnAggregat = new Button();
            btnWhere = new Button();
            SuspendLayout();
            // 
            // btnAggregat
            // 
            btnAggregat.Location = new Point(12, 12);
            btnAggregat.Name = "btnAggregat";
            btnAggregat.Size = new Size(103, 23);
            btnAggregat.TabIndex = 0;
            btnAggregat.Text = "Aggregate";
            btnAggregat.UseVisualStyleBackColor = true;
            btnAggregat.Click += btnAggregat_Click;
            // 
            // btnWhere
            // 
            btnWhere.Location = new Point(12, 41);
            btnWhere.Name = "btnWhere";
            btnWhere.Size = new Size(103, 23);
            btnWhere.TabIndex = 1;
            btnWhere.Text = "Where";
            btnWhere.UseVisualStyleBackColor = true;
            btnWhere.Click += btnWhere_Click;
            // 
            // LinqFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 402);
            Controls.Add(btnWhere);
            Controls.Add(btnAggregat);
            Name = "LinqFrm";
            Text = "LinqFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAggregat;
        private Button btnWhere;
    }
}