using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private double a = 0, b = 0, c = 0;
        char znak = '+';

        private void equal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(".", ",");
            Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
            if ((textBox1.Text != "") && (regex.IsMatch(textBox1.Text)))
            {
                b = Convert.ToDouble(textBox1.Text);
                int flag = 0;
                switch (znak)
                {
                    case '+': c = a + b; break;
                    case '-': c = a - b; break;
                    case 'x': c = a * b; break;
                    case '/':
                        {
                            if (b != 0)
                                c = a / b;
                            else
                            {
                                textBox1.Text = "Error!!!";
                                flag = 1;
                            }
                            break;
                        }
                    case 'S': c = System.Math.Pow(a, (0.5)); ; break;
                    case 'F': c = 1; for (; a != 0; a--)
                            c *= a; break;
                    case 'Q': c = a * a; break;
                }
                if (flag != 1)
                    textBox1.Text = c.ToString("g4");
                flag = 0;
            }
            else textBox1.Text = "Error!!!";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text))
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = (sender as Button).Text[0];
                    textBox1.Clear();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            else textBox1.Text += "-";
            textBox1.Focus();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text))
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = (sender as Button).Text[0];
                    textBox1.Clear();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            else 
                textBox1.Text += "-";
            textBox1.Focus();
        }

        private void mov_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text))
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = (sender as Button).Text[0];
                    textBox1.Clear();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            textBox1.Focus();
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text))
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = (sender as Button).Text[0];
                    textBox1.Clear();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            textBox1.Focus();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            textBox1.Focus();
        }

        private void zero_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void one_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void comma_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text))
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = 'F'; 
                    c = 1; 
                    for (; a != 0; a--)
                        c *= a;
                    textBox1.Text = c.ToString();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            else { textBox1.Text = "Error!!!"; }
            textBox1.Focus();
        }

        private void quadro_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text))
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = 'Q';
                    c = a * a;
                    textBox1.Text = c.ToString();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            else { textBox1.Text = "Error!!!"; }
            textBox1.Focus();
        }

        private void square_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                Regex regex = new Regex("^[-+]?[0-9]+([,]?[0-9]+)?");
                if (regex.IsMatch(textBox1.Text)&&a>0)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = 'S';
                    c = System.Math.Pow(a, (0.5));
                    textBox1.Text = c.ToString();
                }
                else { textBox1.Text = "Error!!!"; }
            }
            else { textBox1.Text = "Error!!!"; }
            textBox1.Focus();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            Close();
        }

        
    }
}
