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
    public partial class Калькулятор : Form
    {
        private void calculate()
        {   switch (count)
            {   case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
        float a, b;
        int count;
        bool znak = true;
        public Калькулятор()
        {
            InitializeComponent();
        }
        private void button27_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 0;  }
        private void button23_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 2;  }
        private void button10_Click(object sender, EventArgs e)
        {}
        private void button4_Click(object sender, EventArgs e)
        {   textBox1.Text = ""; label1.Text = "";   }
        private void button24_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 1;  }
        private void button22_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 3;  }
        private void button20_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 4;  }
        private void button19_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 5;  }
        private void button18_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 6;  }
        private void button16_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 7;  }
        private void button15_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 8;  }
        private void button14_Click(object sender, EventArgs e)
        {   textBox1.Text = textBox1.Text + 9;  }
        private void button21_Click(object sender, EventArgs e)
        {   a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;    }
        private void button17_Click(object sender, EventArgs e)
        {   a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;    }
        private void button13_Click(object sender, EventArgs e)
        {   a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;    }
        private void button9_Click(object sender, EventArgs e)
        {   a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;    }
        private void button11_Click(object sender, EventArgs e)
        { 
            a = float.Parse(textBox1.Text);
            a = (float) Cos(a);
            label1.Text = a.ToString();
        }
        private void button25_Click(object sender, EventArgs e)
        {   calculate();
            label1.Text = "";   }
        private void button1_Click(object sender, EventArgs e)
        {   a = float.Parse(textBox1.Text);
            a = a * (1 / 2);
            textBox1.Text = Convert.ToString(a);    }
        private void button26_Click(object sender, EventArgs e)
        {   
            textBox1.Text = textBox1.Text + ",";    
        }
        static float Factorial(float num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        private void Factorial_Button_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            a = Factorial(a);
            label1.Text = a.ToString();
        }

        public static double Cos(double x, int n = 0, double E = 0.005)
        {
            double Sum = 0;
            while (true)
            {
                var t = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial((2 * n));

                if (Math.Abs(t) < E)
                {
                    return Sum;
                }
                else
                {
                    Sum += t;
                    n++;
                }
            }
        }
    }
}
