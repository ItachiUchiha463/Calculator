namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            num1 = new TextBox();
            num2 = new TextBox();
            result = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(12, 163);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 0;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // num2
            // 
            num2.Location = new Point(300, 164);
            num2.Name = "num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 1;
            // 
            // result
            // 
            result.Location = new Point(509, 163);
            result.Name = "result";
            result.Size = new Size(125, 27);
            result.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "=", "*", "^" });
            comboBox1.Location = new Point(143, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(444, 147);
            label1.Name = "label1";
            label1.Size = new Size(43, 46);
            label1.TabIndex = 4;
            label1.Text = "=";
            // 
            // button1
            // 
            button1.Location = new Point(323, 358);
            button1.Name = "button1";
            button1.Size = new Size(127, 105);
            button1.TabIndex = 5;
            button1.Text = "роз'вязати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(762, 662);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1;
        private TextBox num2;
        private TextBox result;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
    }
}