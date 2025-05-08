namespace AppLearn
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            input1 = new TextBox();
            input2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            resultBox = new TextBox();
            btn_ReverseStringWay1 = new Button();
            btnBrowser = new Button();
            btn_DublicateNumbersInArray = new Button();
            btn_Palindrome = new Button();
            groupBox2 = new GroupBox();
            btnSolidLiskov = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(73, 14);
            input1.Name = "input1";
            input1.Size = new Size(190, 25);
            input1.TabIndex = 0;
            input1.Text = "TestValue";
            // 
            // input2
            // 
            input2.Location = new Point(73, 46);
            input2.Name = "input2";
            input2.Size = new Size(190, 25);
            input2.TabIndex = 1;
            input2.Text = "123456";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 2;
            label1.Text = "Input 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 56);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 3;
            label2.Text = "Input 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resultBox);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(921, 206);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result Box";
            // 
            // resultBox
            // 
            resultBox.BackColor = Color.Black;
            resultBox.Dock = DockStyle.Fill;
            resultBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultBox.ForeColor = Color.WhiteSmoke;
            resultBox.Location = new Point(3, 21);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.ScrollBars = ScrollBars.Both;
            resultBox.Size = new Size(915, 182);
            resultBox.TabIndex = 5;
            // 
            // btn_ReverseStringWay1
            // 
            btn_ReverseStringWay1.Location = new Point(300, 9);
            btn_ReverseStringWay1.Name = "btn_ReverseStringWay1";
            btn_ReverseStringWay1.Size = new Size(284, 26);
            btn_ReverseStringWay1.TabIndex = 6;
            btn_ReverseStringWay1.Text = "Reverse String Way 1";
            btn_ReverseStringWay1.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReverseStringWay1.UseVisualStyleBackColor = true;
            btn_ReverseStringWay1.Click += btn_ReverseStringWay1_Click;
            // 
            // btnBrowser
            // 
            btnBrowser.Location = new Point(300, 37);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(284, 26);
            btnBrowser.TabIndex = 7;
            btnBrowser.Text = "Browser";
            btnBrowser.TextAlign = ContentAlignment.MiddleLeft;
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // btn_DublicateNumbersInArray
            // 
            btn_DublicateNumbersInArray.Location = new Point(300, 65);
            btn_DublicateNumbersInArray.Name = "btn_DublicateNumbersInArray";
            btn_DublicateNumbersInArray.Size = new Size(284, 26);
            btn_DublicateNumbersInArray.TabIndex = 8;
            btn_DublicateNumbersInArray.Text = "Find duplicate numbers in an array";
            btn_DublicateNumbersInArray.TextAlign = ContentAlignment.MiddleLeft;
            btn_DublicateNumbersInArray.UseVisualStyleBackColor = true;
            btn_DublicateNumbersInArray.Click += btn_DublicateNumbersInArray_Click;
            // 
            // btn_Palindrome
            // 
            btn_Palindrome.Location = new Point(300, 93);
            btn_Palindrome.Name = "btn_Palindrome";
            btn_Palindrome.Size = new Size(284, 26);
            btn_Palindrome.TabIndex = 9;
            btn_Palindrome.Text = "Palindrome";
            btn_Palindrome.TextAlign = ContentAlignment.MiddleLeft;
            btn_Palindrome.UseVisualStyleBackColor = true;
            btn_Palindrome.Click += btn_Palindrome_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSolidLiskov);
            groupBox2.Location = new Point(590, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 110);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Solid";
            // 
            // btnSolidLiskov
            // 
            btnSolidLiskov.Location = new Point(6, 24);
            btnSolidLiskov.Name = "btnSolidLiskov";
            btnSolidLiskov.Size = new Size(84, 26);
            btnSolidLiskov.TabIndex = 7;
            btnSolidLiskov.Text = "Liskov";
            btnSolidLiskov.TextAlign = ContentAlignment.MiddleLeft;
            btnSolidLiskov.UseVisualStyleBackColor = true;
            btnSolidLiskov.Click += btnSolidLiskov_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 388);
            Controls.Add(groupBox2);
            Controls.Add(btn_Palindrome);
            Controls.Add(btn_DublicateNumbersInArray);
            Controls.Add(btnBrowser);
            Controls.Add(btn_ReverseStringWay1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input2);
            Controls.Add(input1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Main Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1;
        private TextBox input2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox resultBox;
        private Button btn_ReverseStringWay1;
        private Button btnBrowser;
        private Button btn_DublicateNumbersInArray;
        private Button btn_Palindrome;
        private GroupBox groupBox2;
        private Button btnSolidLiskov;
    }
}
