
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(1, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 68);
            this.textBox1.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(100, 471);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 67);
            this.button0.TabIndex = 1;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 67);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 67);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 67);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(280, 389);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(71, 67);
            this.button_plus.TabIndex = 6;
            this.button_plus.Tag = "1";
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.operation_button_Click);
            // 
            // button_equals
            // 
            this.button_equals.Location = new System.Drawing.Point(280, 471);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(71, 67);
            this.button_equals.TabIndex = 7;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 67);
            this.button4.TabIndex = 9;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(100, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 67);
            this.button5.TabIndex = 10;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(183, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 67);
            this.button6.TabIndex = 11;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 67);
            this.button7.TabIndex = 12;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(100, 223);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 67);
            this.button8.TabIndex = 13;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(183, 222);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 67);
            this.button9.TabIndex = 14;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.num_button_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(280, 305);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(71, 67);
            this.button_minus.TabIndex = 15;
            this.button_minus.Tag = "2";
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.operation_button_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(279, 222);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(71, 67);
            this.button_multiplication.TabIndex = 16;
            this.button_multiplication.Tag = "3";
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.operation_button_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(279, 138);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(71, 67);
            this.button_division.TabIndex = 17;
            this.button_division.Tag = "4";
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.operation_button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(183, 471);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 67);
            this.button10.TabIndex = 18;
            this.button10.Tag = ",";
            this.button10.Text = ",";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.decimal_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(13, 138);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(71, 67);
            this.clear_button.TabIndex = 19;
            this.clear_button.Tag = "7";
            this.clear_button.Text = "CE";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(100, 138);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(71, 67);
            this.delete_button.TabIndex = 20;
            this.delete_button.Tag = "7";
            this.delete_button.Text = "DEL";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(13, 469);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 67);
            this.button11.TabIndex = 21;
            this.button11.Tag = "0";
            this.button11.Text = "+/-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.sign_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(362, 548);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button button11;
    }
}

