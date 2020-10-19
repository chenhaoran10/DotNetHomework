using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCaculator
{
    public partial class Form1 : Form
    {
        public static List<char> inputStr = new List<char>(1000);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputStr.Add('(');

            richTextBox1.AppendText("(");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputStr.Add('0');

            richTextBox1.AppendText("0");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            inputStr.Add('.');
            richTextBox1.AppendText(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputStr.Add('1');

            richTextBox1.AppendText("1");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputStr.Add('2');

            richTextBox1.AppendText("2")
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inputStr.Add('3');

            richTextBox1.AppendText("3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputStr.Add('4');

            richTextBox1.AppendText("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputStr.Add('5');

            richTextBox1.AppendText("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputStr.Add('6');

            richTextBox1.AppendText("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputStr.Add('7');

            richTextBox1.AppendText("7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputStr.Add('8');

            richTextBox1.AppendText("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputStr.Add('9');

            richTextBox1.AppendText("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputStr.Add(')');

            richTextBox1.AppendText(")");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("=");

            richTextBox1.Text = richTextBox1.Text;

            richTextBox1.Text = DataOp.DataMain();

            string temp = DataOp.DataMain();

            inputStr.Clear();

            for (int i = 0; i < temp.Length; i++)
            {

                inputStr.Add(temp[i]);

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            inputStr.Add('+');

            richTextBox1.AppendText("+");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputStr.Add('-');
            richTextBox1.AppendText("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inputStr.Add('×');
            richTextBox1.AppendText("×");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputStr.Add('÷');
            richTextBox1.AppendText("÷");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            inputStr.Clear(); //清空链表的所有元素
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputStr.RemoveAt(inputStr.Count - 1);
            richTextBox1.Text = "";
            for (int i = 0; i < inputStr.Count; i++)
            {
                richTextBox1.Text += inputStr[i];
            }
        }
    }
}
