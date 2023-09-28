using System.CodeDom;
using System.Data.Common;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private decimal Valuef = 0.0m;
        private decimal Values = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "2";
            }
            else
            {
                c.Text = "2";
            }
        }

        private void c_TextChanged(object sender, EventArgs e)
        {
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "1";
            }
            else
            {
                c.Text = "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "3";
            }
            else
            {
                c.Text = "3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valuef != 0.0m)
            {
                c.Text = "";
            }
            if (c.Text != "0")
            {
                c.Text += "4";
            }
            else
            {
                c.Text = "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Valuef != 0.0m)
            {
                c.Text = "";
            }
            if (c.Text != "0")
            {
                c.Text += "7";
            }
            else
            {
                c.Text = "7";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += ".";
            }
            else
            {
                c.Text = "0";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Text = "0";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "5";
            }
            else
            {
                c.Text = "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "6";
            }
            else
            {
                c.Text = "6";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "8";
            }
            else
            {
                c.Text = "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "9";
            }
            else
            {
                c.Text = "9";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!c.Text.Contains("."))
            {
                c.Text += ".";
            }
        }

        private void zero_Click_1(object sender, EventArgs e)
        {
            if (c.Text != "0")
            {
                c.Text += "0";
            }
            else { c.Text = "0"; }
        }

        private void minusplus_Click(object sender, EventArgs e)
        {
            if (c.Text.Contains('-'))
            {
                c.Text = c.Text.Trim('-');
            }
            else
            {
                c.Text = '-' + c.Text;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Valuef = decimal.Parse(c.Text);
            c.Text = "";
            operators = "-";

        }

        private void plus_Click(object sender, EventArgs e)
        {
            Valuef = decimal.Parse(c.Text);
            c.Text = "";
            operators = "+";
        }

        private void device_Click(object sender, EventArgs e)
        {
            Valuef = decimal.Parse(c.Text);
            c.Text = "";
            operators = "/";
        }

        private void mltiply_Click(object sender, EventArgs e)
        {
            Valuef = decimal.Parse(c.Text);
            c.Text = "";
            operators = "*";
        }

        private void modul_Click(object sender, EventArgs e)
        {
            
             Valuef = decimal.Parse(c.Text);
             c.Text = "";
             operators = "%";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Values = decimal.Parse(c.Text);
            switch (operators)
            {
                case "":
                    break;
                case "+":
                    result = Valuef + Values;
                    c.Text = result.ToString();
                    break;
                case "-":
                    result = Valuef - Values;
                    c.Text = result.ToString();
                    break;
                case "*":
                    result = Valuef * Values;
                    c.Text = result.ToString();
                    break;
                case "/":
                    result = Valuef / Values;
                    c.Text = result.ToString();
                    break;
                case "%":
                    result = Valuef % Values;
                    c.Text = result.ToString();
                    break;
            }

        }
    }
}