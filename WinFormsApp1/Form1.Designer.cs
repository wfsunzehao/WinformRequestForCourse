namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            cURLText = new TextBox();
            listView1 = new ListView();
            label1 = new Label();
            CourseIdText = new TextBox();
            SourceIdText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            listView2 = new ListView();
            label4 = new Label();
            ClearRespons = new Button();
            Refer = new Label();
            Reference = new Label();
            label7 = new Label();
            CookieValue = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(556, 26);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 0;
            button1.Text = "导入cURL更新请求头";
            button1.UseVisualStyleBackColor = true;
            // 
            // cURLText
            // 
            cURLText.Location = new Point(76, 35);
            cURLText.Name = "cURLText";
            cURLText.Size = new Size(449, 23);
            cURLText.TabIndex = 1;
            cURLText.TextChanged += textBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(76, 86);
            listView1.Name = "listView1";
            listView1.Size = new Size(165, 352);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 68);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "请求头";
            // 
            // CourseIdText
            // 
            CourseIdText.Location = new Point(499, 198);
            CourseIdText.Name = "CourseIdText";
            CourseIdText.Size = new Size(264, 23);
            CourseIdText.TabIndex = 4;
            CourseIdText.TextChanged += textBox2_TextChanged;
            // 
            // SourceIdText
            // 
            SourceIdText.Location = new Point(499, 265);
            SourceIdText.Name = "SourceIdText";
            SourceIdText.Size = new Size(264, 23);
            SourceIdText.TabIndex = 5;
            SourceIdText.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 206);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "CourseId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 273);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "SourceId";
            // 
            // button2
            // 
            button2.Location = new Point(649, 354);
            button2.Name = "button2";
            button2.Size = new Size(114, 50);
            button2.TabIndex = 8;
            button2.Text = "自动刷课";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(247, 86);
            listView2.Name = "listView2";
            listView2.Size = new Size(161, 352);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 68);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "响应体";
            // 
            // ClearRespons
            // 
            ClearRespons.Location = new Point(412, 86);
            ClearRespons.Name = "ClearRespons";
            ClearRespons.Size = new Size(75, 23);
            ClearRespons.TabIndex = 11;
            ClearRespons.Text = "清空响应";
            ClearRespons.UseVisualStyleBackColor = true;
            // 
            // Refer
            // 
            Refer.AutoSize = true;
            Refer.Location = new Point(428, 125);
            Refer.Name = "Refer";
            Refer.Size = new Size(59, 15);
            Refer.TabIndex = 12;
            Refer.Text = "Reference";
            // 
            // Reference
            // 
            Reference.AutoSize = true;
            Reference.Font = new Font("Segoe UI", 9F);
            Reference.Location = new Point(499, 125);
            Reference.Name = "Reference";
            Reference.Size = new Size(38, 15);
            Reference.TabIndex = 13;
            Reference.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 165);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 14;
            label7.Text = "CookieValue";
            // 
            // CookieValue
            // 
            CookieValue.AutoSize = true;
            CookieValue.Location = new Point(499, 165);
            CookieValue.Name = "CookieValue";
            CookieValue.Size = new Size(38, 15);
            CookieValue.TabIndex = 15;
            CookieValue.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CookieValue);
            Controls.Add(label7);
            Controls.Add(Reference);
            Controls.Add(Refer);
            Controls.Add(ClearRespons);
            Controls.Add(label4);
            Controls.Add(listView2);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SourceIdText);
            Controls.Add(CourseIdText);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(cURLText);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox cURLText;
        private ListView listView1;
        private Label label1;
        private TextBox CourseIdText;
        private TextBox SourceIdText;
        private Label label2;
        private Label label3;
        private Button button2;
        private ListView listView2;
        private Label label4;
        private Button ClearRespons;
        private Label Refer;
        private Label Reference;
        private Label label7;
        private Label CookieValue;
    }
}
