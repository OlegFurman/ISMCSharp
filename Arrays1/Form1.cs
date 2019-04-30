using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
            
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxN.Text))
            {
                MessageBox.Show("Enter the number of elements");
            }
            else
            {
                try
                {
                    int n;
                    n = Convert.ToInt32(textBoxN.Text);
                    dataArr.ColumnCount = n;
                    dataArr.RowCount = 1;
                    buttonFill.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("number of elements entered incorrectly");
                }
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            double max = 100, min = -100;
            int n = dataArr.ColumnCount;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                dataArr[i, 0].Value = Math.Round(rand.NextDouble() * Math.Abs(max - min) + min, 1);
            }
            buttonCalculate.Visible = true; labelSumNg.Visible = true; SumNg.Visible = true;
            labelMax.Visible = true; Max.Visible = true;
            labelMaxInd.Visible = true; MaxInd.Visible = true;
            labelMaxAbs.Visible = true; MaxAbs.Visible = true;
            labelSumPosInd.Visible = true; SumPosInd.Visible = true;
            labelCountInt.Visible = true; CountInt.Visible = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double [n];
            double sumNg = 0,sumPosInd = 0;
            int maxInd = 0,countInt = 0;
            double max = double.MinValue;
            double maxm = max;                 
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sumNg += arr[i];

                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxInd = i;
                }
                if (Math.Abs(arr[i]) > maxm)
                {
                    maxm = Math.Abs(arr[i]);
                    max = arr[i];
                }
                if (arr[i] > 0)
                {
                    sumPosInd += i;

                }
                if (Convert.ToInt32(arr[i]) == arr[i])
                {
                    countInt++;
                }

            }
            SumNg.Text = sumNg.ToString();
            Max.Text = max.ToString();
            MaxInd.Text = maxInd.ToString();
            MaxAbs.Text = maxm.ToString();
            SumPosInd.Text = sumPosInd.ToString();
            CountInt.Text = countInt.ToString();
        }


    }
}
