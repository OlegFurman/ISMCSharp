using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCount_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < n; i++)
                    {
                        dataArr.Columns[i].HeaderText = i.ToString();
                        dataArr.Columns[i].Width = 50;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("number of elements entered incorrectly");
                }
            }
        }

        private void ButtonFill_Click(object sender, EventArgs e)
        {
            double max = 100, min = -100;
            int n = dataArr.ColumnCount;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                dataArr[i, 0].Value = Math.Round(rand.NextDouble() * Math.Abs(max - min) + min, 1);
            }
            buttonCalculate.Visible = true;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double[] array = new double[dataArr.ColumnCount];
            bool check = true;
            for (int i = 0; i < dataArr.ColumnCount; i++)
            {
                check = double.TryParse(dataArr.Rows[0].Cells[i].Value.ToString(), out array[i]);
                if (!check)
                {
                    MessageBox.Show("cell is empty or contains not a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int index_min = -1, index_pos = -1, index_neg = -1, index_first_zero = -1, index_second_zero = -1;
            double Min = double.MaxValue;
            double ProdAfterMin = 1;
            bool second_pos = false;         
            double SumBetweenNegAndPos = 0, SumBetweenZeroElements = 0;
            int index_min_abs = -1, index_max_abs = -1;
            double MinAbs = double.MaxValue,MaxAbs = double.MinValue ;         
            double ProdBetweenMaxAndMin = 1;
            int temp_1, temp_2;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Min) { Min = array[i]; index_min = i; }
                if (index_neg == -1 && array[i] < 0) index_neg = i;
                if (!second_pos && array[i] > 0) second_pos = true;
                else
                if (second_pos && index_pos == -1 && array[i] > 0) index_pos = i;
                if (index_first_zero == -1 && array[i] == 0) index_first_zero = i;
                else
                if (index_first_zero != -1 && index_second_zero == -1 && array[i] == 0) index_second_zero = i;
                if (Math.Abs(array[i]) < MinAbs) { MinAbs = Math.Abs(array[i]); index_min_abs = i; }
                if (Math.Abs(array[i]) > MaxAbs) { MaxAbs = Math.Abs(array[i]); index_max_abs = i; }
            }
            if (index_min == array.Length - 1)
            {
                labelAfterMin.Text = "The minimum element of the array is the last!";
            }
            else
            {
                for (int i = index_min + 1; i < array.Length; i++)
                {
                    ProdAfterMin *= array[i];
                }
                labelAfterMin.Text = Math.Round(ProdAfterMin, 3).ToString();
            }

            if (index_pos == -1 && index_neg == -1)
            {
                labelSumBetweenNegAndPos.Text = "Negative and second positive items not found!";
            }
            else
            if (index_neg == -1)
            {
                labelSumBetweenNegAndPos.Text = "Negative item not found!";
            }
            else
            if (index_pos == -1)
            {
                labelSumBetweenNegAndPos.Text = "Positive item not found!";
            }
            else
            {
                if (index_pos > index_neg) { temp_1 = index_neg; temp_2 = index_pos; }
                else { temp_1 = index_pos; temp_2 = index_neg; }
                for (int i = temp_1 + 1; i < temp_2; i++)
                {
                    SumBetweenNegAndPos += array[i];
                }
                labelSumBetweenNegAndPos.Text = Math.Round(SumBetweenNegAndPos, 3).ToString();
            }

            if (index_first_zero == -1)
            {
                labelSumBetweenZeroElements.Text = "No zeros found!";
            }
            else
            if (index_second_zero == -1)
            {
                labelSumBetweenZeroElements.Text = "The second zero is not found!";
            }
            else
            {
                for (int i = index_first_zero + 1; i < index_second_zero; i++)
                {
                    SumBetweenZeroElements += array[i];
                }
                labelSumBetweenZeroElements.Text = Math.Round(SumBetweenZeroElements, 3).ToString();
            }

            if (index_min_abs + 1 == index_max_abs || index_min_abs == index_max_abs + 1)
            {
                labelProdBetweenMaxAndMin.Text = "Min and Max are standing next to the array!";
            }
            else
            {
                if (index_min_abs > index_max_abs) { temp_1 = index_max_abs; temp_2 = index_min_abs; }
                else { temp_1 = index_min_abs; temp_2 = index_max_abs; }
                for (int i = temp_1 + 1; i < temp_2; i++)
                {
                    ProdBetweenMaxAndMin *= array[i];
                }
                labelProdBetweenMaxAndMin.Text = Math.Round(ProdBetweenMaxAndMin, 3).ToString();
            }

        }

        
    }
}
