namespace Calculator
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
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            button9 = new Button();
            button1 = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btnEquals = new Button();
            btnSqrt = new Button();
            button2 = new Button();
            button3 = new Button();
            btnPlusMinus = new Button();
            lstHistory = new ListBox();
            btnClearHistory = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.White;
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Location = new Point(29, 38);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(184, 27);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.GradientActiveCaption;
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(12, 154);
            btn1.Name = "btn1";
            btn1.Size = new Size(35, 30);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Digital_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.GradientActiveCaption;
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(12, 118);
            btn4.Name = "btn4";
            btn4.Size = new Size(35, 30);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Digital_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.GradientActiveCaption;
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(12, 82);
            btn7.Name = "btn7";
            btn7.Size = new Size(35, 30);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Digital_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.GradientActiveCaption;
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(53, 154);
            btn2.Name = "btn2";
            btn2.Size = new Size(35, 30);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Digital_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.GradientActiveCaption;
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(53, 118);
            btn5.Name = "btn5";
            btn5.Size = new Size(35, 30);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Digital_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.GradientActiveCaption;
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(53, 82);
            btn8.Name = "btn8";
            btn8.Size = new Size(35, 30);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Digital_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.GradientActiveCaption;
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(94, 82);
            btn9.Name = "btn9";
            btn9.Size = new Size(35, 30);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Digital_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.GradientActiveCaption;
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(94, 118);
            btn6.Name = "btn6";
            btn6.Size = new Size(35, 30);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Digital_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.GradientActiveCaption;
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(94, 154);
            btn3.Name = "btn3";
            btn3.Size = new Size(35, 30);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Digital_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.GradientActiveCaption;
            button9.ForeColor = Color.Black;
            button9.Location = new Point(53, 190);
            button9.Name = "button9";
            button9.Size = new Size(35, 30);
            button9.TabIndex = 10;
            button9.Text = "0";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Digital_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(135, 83);
            button1.Name = "button1";
            button1.Size = new Size(36, 29);
            button1.TabIndex = 11;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Operator_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.GradientActiveCaption;
            btnSubtract.ForeColor = Color.Black;
            btnSubtract.Location = new Point(135, 119);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(36, 29);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += Operator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.GradientActiveCaption;
            btnMultiply.ForeColor = Color.Black;
            btnMultiply.Location = new Point(135, 155);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(36, 29);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += Operator_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.GradientActiveCaption;
            btnDivide.ForeColor = Color.Black;
            btnDivide.Location = new Point(135, 191);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(36, 29);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(12, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(36, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.GradientActiveCaption;
            btnEquals.ForeColor = Color.Black;
            btnEquals.Location = new Point(93, 191);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(36, 29);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.GradientActiveCaption;
            btnSqrt.ForeColor = Color.Black;
            btnSqrt.Location = new Point(177, 118);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(36, 29);
            btnSqrt.TabIndex = 17;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(177, 83);
            button2.Name = "button2";
            button2.Size = new Size(36, 29);
            button2.TabIndex = 18;
            button2.Text = "⌫";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnBackspace_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(177, 156);
            button3.Name = "button3";
            button3.Size = new Size(36, 29);
            button3.TabIndex = 19;
            button3.Text = ".";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Digital_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = SystemColors.GradientActiveCaption;
            btnPlusMinus.ForeColor = Color.Black;
            btnPlusMinus.Location = new Point(177, 191);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(40, 29);
            btnPlusMinus.TabIndex = 20;
            btnPlusMinus.Text = "-/+";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(238, 38);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(90, 144);
            lstHistory.TabIndex = 21;
            // 
            // btnClearHistory
            // 
            btnClearHistory.Location = new Point(238, 191);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(90, 29);
            btnClearHistory.TabIndex = 22;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1057, 626);
            Controls.Add(btnClearHistory);
            Controls.Add(lstHistory);
            Controls.Add(btnPlusMinus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSqrt);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Click += Digital_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button button9;
        private Button button1;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
        private Button btnEquals;
        private Button btnSqrt;
        private Button button2;
        private Button button3;
        private Button btnPlusMinus;
        private ListBox lstHistory;
        private Button btnClearHistory;
    }
}
