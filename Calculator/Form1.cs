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
        public string no1, operand;
        public bool inputstatus;
        public Form1()
        {
            InitializeComponent();
            no1 = "";
            textBox1.ReadOnly = true;                //to set textbox to read only mode
            textBox1.RightToLeft = RightToLeft.Yes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            operand = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button1.Text;
            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button2.Text;
            }
            else
            {
                textBox1.Text = button2.Text;
                inputstatus = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button3.Text;
            }
            else
            {
                textBox1.Text = button3.Text;
                inputstatus = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button4.Text;
            }
            else
            {
                textBox1.Text = button4.Text;
                inputstatus = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button5.Text;
            }
            else
            {
                textBox1.Text = button5.Text;
                inputstatus = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button6.Text;
            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button7.Text;
            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button8.Text;
            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button9.Text;
            }
            else
            {
                textBox1.Text = button9.Text;
                inputstatus = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button10.Text;
            }
            else
            {
                textBox1.Text = button10.Text;
                inputstatus = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            inputstatus = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            operand = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            operand = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            operand = "x";
        }

        private void Operation()
        {
            switch (operand)
            {
                case "+":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) + Convert.ToInt32(textBox1.Text)); 

                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));

                    break;
                case "x":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(textBox1.Text));
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "infinity";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToInt32(no1) / Convert.ToInt32(textBox1.Text));
                    }
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operation();
            inputstatus = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "0";
            /* button1.Enabled = true;
             button2.Enabled = true; 
             button3.Enabled = true;
             button4.Enabled = true;
             button5.Enabled = true;
             button6.Enabled = true;
             button7.Enabled = true;
             button8.Enabled = true;
             button9.Enabled = true;
             button10.Enabled = true;
             button11.Enabled = true;
             button12.Enabled = true;
             button13.Enabled = true;
             button14.Enabled = true;
             button15.Enabled = true;
             button16.Enabled = true;
             button18.Enabled = true;
             button21.Enabled = true;
             button22.Enabled = true;
             button20.Enabled = true;
             button23.Enabled = true;*/
            foreach (Button button in this.Controls.OfType<Button>())
                button.Enabled = true;
        }
       
private void button18_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n==0)
                textBox1.Text ="";
            else
            textBox1.Text = (no1.Substring(0, n - 1));

        }
        
private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if(button != button17)
                button.Enabled = false;
            }
           /* button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button20.Enabled = false;
            button23.Enabled = false;*/

            textBox1.Text = "";
            inputstatus = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int var1 = 1;
            for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
            inputstatus = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
