using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class QuadEquationWinForm : Form
    {
        public QuadEquationWinForm()
        {
            InitializeComponent();
            textBox4.Visible = false; 
            textBox5.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            double a, b, c;
            double D, x1, x2;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(textBox1.Text);
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(textBox2.Text);
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(textBox3.Text);
            D = Math.Pow(b, 2) - 4 * a * c;
            
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                textBox4.Text = x1.ToString();
                textBox5.Text = x2.ToString();
                textBox4.Visible = true;
                textBox5.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    textBox4.Text = x1.ToString();
                    textBox4.Visible = true;  
                    label4.Visible = true;                  
                }
                else
                {
                    MessageBox.Show("Solution does not exist");
                }

            }

        }
    }
}
