using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private StringBuilder expression = new StringBuilder();
        private double answer;

        private void button0_Click(object sender, EventArgs e)
        {
            expression.Append('0');
            textBox1.Text = expression.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression.Append('1');
            textBox1.Text = expression.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expression.Append('2');
            textBox1.Text = expression.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expression.Append('3');
            textBox1.Text = expression.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            expression.Append('4');
            textBox1.Text = expression.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression.Append('5');
            textBox1.Text = expression.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression.Append('6');
            textBox1.Text = expression.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression.Append('7');
            textBox1.Text = expression.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression.Append('8');
            textBox1.Text = expression.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expression.Append('9');
            textBox1.Text = expression.ToString();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            expression.Append('.');
            textBox1.Text = expression.ToString();
        }

        private void buttonLeftParentheses_Click(object sender, EventArgs e)
        {
            expression.Append('(');
            textBox1.Text = expression.ToString();
        }

        private void buttonRightParentheses_Click(object sender, EventArgs e)
        {
            expression.Append(')');
            textBox1.Text = expression.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            expression.Append('+');
            textBox1.Text = expression.ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            expression.Append('-');
            textBox1.Text = expression.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            expression.Append('*');
            textBox1.Text = expression.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            expression.Append('/');
            textBox1.Text = expression.ToString();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            int index = 0;
            answer = CalculatorLogic.parseEquation(expression.ToString(), ref index);
            textBox1.Text = answer.ToString();
            expression.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (expression.Length > 0)
            {
                expression.Remove(expression.Length - 1, 1);
                textBox1.Text = expression.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            expression.Clear();
            textBox1.Text = expression.ToString();
        }

        private void buttonPreviousAnswer_Click(object sender, EventArgs e)
        {
            expression.Append(answer.ToString());
            textBox1.Text = expression.ToString();
        }

        private void textBox_1(object sender, EventArgs e)
        {

        }

        private void buttonPositiveNegative_Click(object sender, EventArgs e)
        {

        }
    }
}
