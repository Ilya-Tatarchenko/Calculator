using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {

        Calculation Calculation = new Calculation();

        float firstValue;
        float secondValue;
        
        int typeOper;
        //bool isFocused;
        bool sign = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void calculate()
        {
            switch (typeOper) 
            {
                case 1:
                    textBox1.Text = Calculation.Plus(firstValue, secondValue);
                    break;

                case 2:
                    textBox1.Text = Calculation.Minus(firstValue, secondValue);
                    if (firstValue - secondValue < 0)
                        sign = false;
                    break;

                case 3:
                    textBox1.Text = Calculation.Multiplication(firstValue, secondValue);
                    break;

                case 4:
                    textBox1.Text = Calculation.Division(firstValue, secondValue);
                    break;
            }
        }

        private void num_button_Click(object sender, EventArgs e)
        {
            int ClickValue;
            ClickValue = Convert.ToInt32((sender as Button).Tag);

            textBox1.Text = textBox1.Text + Convert.ToString(ClickValue);

            label1.Text = label1.Text + Convert.ToString(ClickValue);

            //isFocused = textBox1.Focus();
        }

        private void decimal_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
            label1.Text = label1.Text + ",";
        }

        private void operation_button_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();

            typeOper = Convert.ToInt32((sender as Button).Tag);

            switch (typeOper)
            {
                case 1:
                    label1.Text = firstValue.ToString() + "+";
                    break;

                case 2:
                    label1.Text = firstValue.ToString() + "-";
                    break;

                case 3:
                    label1.Text = firstValue.ToString() + "*";
                    break;

                case 4:
                    label1.Text = firstValue.ToString() + "/";
                    break;
            }

            //isFocused = textBox1.Focus();
            sign = true;
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            secondValue = float.Parse(textBox1.Text);
            label1.Text = label1.Text + '=';
            calculate();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int nLength = textBox1.Text.Length;
            int nLengthLabel = label1.Text.Length;

            textBox1.Text = textBox1.Text.Remove(nLength - 1);
            label1.Text = label1.Text.Remove(nLengthLabel - 1);
        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Trim('-');
                sign = true;
            }
        }
    }
}
