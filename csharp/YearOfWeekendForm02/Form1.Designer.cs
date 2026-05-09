namespace YearOfWeekendForm02
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
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F);
            label2.Location = new Point(273, 333);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F);
            button1.Location = new Point(329, 233);
            button1.Name = "button1";
            button1.Size = new Size(124, 59);
            button1.TabIndex = 7;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(287, 93);
            label1.Name = "label1";
            label1.Size = new Size(223, 43);
            label1.TabIndex = 5;
            label1.Text = "請輸入西元年";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}
