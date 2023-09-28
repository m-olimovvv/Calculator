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
            one = new Button();
            two = new Button();
            c = new TextBox();
            fourBtn = new Button();
            five = new Button();
            three = new Button();
            six = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            clear = new Button();
            dot = new Button();
            equal = new Button();
            zero = new Button();
            minusplus = new Button();
            modul = new Button();
            device = new Button();
            mltiply = new Button();
            minus = new Button();
            plus = new Button();
            SuspendLayout();
            // 
            // one
            // 
            one.Location = new Point(32, 286);
            one.Name = "one";
            one.Size = new Size(85, 76);
            one.TabIndex = 0;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // two
            // 
            two.Location = new Point(138, 286);
            two.Name = "two";
            two.Size = new Size(85, 78);
            two.TabIndex = 1;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // c
            // 
            c.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(32, 12);
            c.Multiline = true;
            c.Name = "c";
            c.Size = new Size(516, 48);
            c.TabIndex = 2;
            c.Text = "0";
            c.TextAlign = HorizontalAlignment.Right;
            c.TextChanged += c_TextChanged;
            // 
            // fourBtn
            // 
            fourBtn.Location = new Point(32, 186);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(85, 80);
            fourBtn.TabIndex = 3;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += button1_Click;
            // 
            // five
            // 
            five.Location = new Point(138, 184);
            five.Name = "five";
            five.Size = new Size(85, 82);
            five.TabIndex = 4;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // three
            // 
            three.BackColor = SystemColors.ControlLight;
            three.Location = new Point(246, 286);
            three.Name = "three";
            three.Size = new Size(85, 76);
            three.TabIndex = 5;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += button3_Click;
            // 
            // six
            // 
            six.Location = new Point(246, 184);
            six.Name = "six";
            six.Size = new Size(85, 82);
            six.TabIndex = 6;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // seven
            // 
            seven.Location = new Point(32, 96);
            seven.Name = "seven";
            seven.Size = new Size(85, 82);
            seven.TabIndex = 7;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += button7_Click;
            // 
            // eight
            // 
            eight.Location = new Point(138, 96);
            eight.Name = "eight";
            eight.Size = new Size(85, 80);
            eight.TabIndex = 8;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.Location = new Point(246, 96);
            nine.Name = "nine";
            nine.Size = new Size(85, 80);
            nine.TabIndex = 9;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // clear
            // 
            clear.Location = new Point(360, 102);
            clear.Name = "clear";
            clear.Size = new Size(176, 76);
            clear.TabIndex = 10;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button4_Click;
            // 
            // dot
            // 
            dot.Location = new Point(138, 383);
            dot.Name = "dot";
            dot.Size = new Size(85, 76);
            dot.TabIndex = 11;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // equal
            // 
            equal.Location = new Point(246, 383);
            equal.Name = "equal";
            equal.Size = new Size(85, 76);
            equal.TabIndex = 12;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // zero
            // 
            zero.Location = new Point(32, 383);
            zero.Name = "zero";
            zero.Size = new Size(85, 76);
            zero.TabIndex = 13;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click_1;
            // 
            // minusplus
            // 
            minusplus.Location = new Point(360, 383);
            minusplus.Name = "minusplus";
            minusplus.Size = new Size(85, 76);
            minusplus.TabIndex = 20;
            minusplus.Text = "-/=";
            minusplus.UseVisualStyleBackColor = true;
            minusplus.Click += minusplus_Click;
            // 
            // modul
            // 
            modul.Location = new Point(451, 383);
            modul.Name = "modul";
            modul.Size = new Size(85, 76);
            modul.TabIndex = 21;
            modul.Text = "%";
            modul.UseVisualStyleBackColor = true;
            modul.Click += modul_Click;
            // 
            // device
            // 
            device.Location = new Point(360, 290);
            device.Name = "device";
            device.Size = new Size(85, 76);
            device.TabIndex = 22;
            device.Text = "/";
            device.UseVisualStyleBackColor = true;
            device.Click += device_Click;
            // 
            // mltiply
            // 
            mltiply.Location = new Point(451, 290);
            mltiply.Name = "mltiply";
            mltiply.Size = new Size(85, 76);
            mltiply.TabIndex = 23;
            mltiply.Text = "*";
            mltiply.UseVisualStyleBackColor = true;
            mltiply.Click += mltiply_Click;
            // 
            // minus
            // 
            minus.Location = new Point(360, 188);
            minus.Name = "minus";
            minus.Size = new Size(85, 76);
            minus.TabIndex = 24;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.Location = new Point(451, 190);
            plus.Name = "plus";
            plus.Size = new Size(85, 76);
            plus.TabIndex = 25;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 471);
            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(mltiply);
            Controls.Add(device);
            Controls.Add(modul);
            Controls.Add(minusplus);
            Controls.Add(zero);
            Controls.Add(equal);
            Controls.Add(dot);
            Controls.Add(clear);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(three);
            Controls.Add(five);
            Controls.Add(fourBtn);
            Controls.Add(c);
            Controls.Add(two);
            Controls.Add(one);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button one;
        private Button two;
        private TextBox c;
        private Button fourBtn;
        private Button five;
        private Button three;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button clear;
        private Button dot;
        private Button equal;
        private Button zero;
        private Button minusplus;
        private Button modul;
        private Button device;
        private Button mltiply;
        private Button minus;
        private Button plus;
    }
}