namespace Arrays1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCount = new System.Windows.Forms.Button();
            this.dataArr = new System.Windows.Forms.DataGridView();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSumNg = new System.Windows.Forms.Label();
            this.SumNg = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.MaxInd = new System.Windows.Forms.Label();
            this.labelMaxInd = new System.Windows.Forms.Label();
            this.MaxAbs = new System.Windows.Forms.Label();
            this.labelMaxAbs = new System.Windows.Forms.Label();
            this.SumPosInd = new System.Windows.Forms.Label();
            this.labelSumPosInd = new System.Windows.Forms.Label();
            this.CountInt = new System.Windows.Forms.Label();
            this.labelCountInt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(361, 14);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(78, 34);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Додати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // dataArr
            // 
            this.dataArr.AllowUserToAddRows = false;
            this.dataArr.AllowUserToDeleteRows = false;
            this.dataArr.AllowUserToOrderColumns = true;
            this.dataArr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataArr.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArr.Location = new System.Drawing.Point(13, 66);
            this.dataArr.Margin = new System.Windows.Forms.Padding(4);
            this.dataArr.Name = "dataArr";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataArr.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataArr.RowHeadersWidth = 5;
            this.dataArr.Size = new System.Drawing.Size(674, 265);
            this.dataArr.TabIndex = 1;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(13, 18);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(281, 24);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Введіть кількість елементів:";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(302, 18);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(53, 29);
            this.textBoxN.TabIndex = 3;
            // 
            // buttonFill
            // 
            this.buttonFill.Enabled = false;
            this.buttonFill.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFill.Location = new System.Drawing.Point(446, 14);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(103, 34);
            this.buttonFill.TabIndex = 4;
            this.buttonFill.Text = "Заповнити";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(555, 14);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(117, 34);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Visible = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSumNg
            // 
            this.labelSumNg.AutoSize = true;
            this.labelSumNg.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumNg.Location = new System.Drawing.Point(13, 343);
            this.labelSumNg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumNg.Name = "labelSumNg";
            this.labelSumNg.Size = new System.Drawing.Size(314, 24);
            this.labelSumNg.TabIndex = 6;
            this.labelSumNg.Text = "Сума від’ємних елементів масиву";
            this.labelSumNg.Visible = false;
            // 
            // SumNg
            // 
            this.SumNg.AutoSize = true;
            this.SumNg.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumNg.Location = new System.Drawing.Point(273, 343);
            this.SumNg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SumNg.Name = "SumNg";
            this.SumNg.Size = new System.Drawing.Size(0, 23);
            this.SumNg.TabIndex = 7;
            this.SumNg.Visible = false;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Max.Location = new System.Drawing.Point(273, 380);
            this.Max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(0, 23);
            this.Max.TabIndex = 10;
            this.Max.Visible = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.Location = new System.Drawing.Point(13, 380);
            this.labelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(233, 24);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Максимальний елемент";
            this.labelMax.Visible = false;
            // 
            // MaxInd
            // 
            this.MaxInd.AutoSize = true;
            this.MaxInd.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.MaxInd.Location = new System.Drawing.Point(273, 415);
            this.MaxInd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxInd.Name = "MaxInd";
            this.MaxInd.Size = new System.Drawing.Size(0, 23);
            this.MaxInd.TabIndex = 13;
            this.MaxInd.Visible = false;
            // 
            // labelMaxInd
            // 
            this.labelMaxInd.AutoSize = true;
            this.labelMaxInd.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxInd.Location = new System.Drawing.Point(13, 415);
            this.labelMaxInd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxInd.Name = "labelMaxInd";
            this.labelMaxInd.Size = new System.Drawing.Size(309, 24);
            this.labelMaxInd.TabIndex = 12;
            this.labelMaxInd.Text = "Індекс максимального елемента";
            this.labelMaxInd.Visible = false;
            // 
            // MaxAbs
            // 
            this.MaxAbs.AutoSize = true;
            this.MaxAbs.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.MaxAbs.Location = new System.Drawing.Point(306, 453);
            this.MaxAbs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxAbs.Name = "MaxAbs";
            this.MaxAbs.Size = new System.Drawing.Size(0, 23);
            this.MaxAbs.TabIndex = 16;
            this.MaxAbs.Visible = false;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxAbs.Location = new System.Drawing.Point(12, 453);
            this.labelMaxAbs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(343, 24);
            this.labelMaxAbs.TabIndex = 15;
            this.labelMaxAbs.Text = "Максимальний елемент за модулем";
            this.labelMaxAbs.Visible = false;
            // 
            // SumPosInd
            // 
            this.SumPosInd.AutoSize = true;
            this.SumPosInd.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumPosInd.Location = new System.Drawing.Point(288, 486);
            this.SumPosInd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SumPosInd.Name = "SumPosInd";
            this.SumPosInd.Size = new System.Drawing.Size(0, 23);
            this.SumPosInd.TabIndex = 19;
            this.SumPosInd.Visible = false;
            // 
            // labelSumPosInd
            // 
            this.labelSumPosInd.AutoSize = true;
            this.labelSumPosInd.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumPosInd.Location = new System.Drawing.Point(12, 486);
            this.labelSumPosInd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumPosInd.Name = "labelSumPosInd";
            this.labelSumPosInd.Size = new System.Drawing.Size(327, 24);
            this.labelSumPosInd.TabIndex = 18;
            this.labelSumPosInd.Text = "Сума індексів додатних елементів";
            this.labelSumPosInd.Visible = false;
            // 
            // CountInt
            // 
            this.CountInt.AutoSize = true;
            this.CountInt.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.CountInt.Location = new System.Drawing.Point(273, 522);
            this.CountInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountInt.Name = "CountInt";
            this.CountInt.Size = new System.Drawing.Size(0, 23);
            this.CountInt.TabIndex = 22;
            this.CountInt.Visible = false;
            // 
            // labelCountInt
            // 
            this.labelCountInt.AutoSize = true;
            this.labelCountInt.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountInt.Location = new System.Drawing.Point(12, 522);
            this.labelCountInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountInt.Name = "labelCountInt";
            this.labelCountInt.Size = new System.Drawing.Size(281, 24);
            this.labelCountInt.TabIndex = 21;
            this.labelCountInt.Text = "Кількість цілих чисел у масиві";
            this.labelCountInt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 602);
            this.Controls.Add(this.CountInt);
            this.Controls.Add(this.labelCountInt);
            this.Controls.Add(this.SumPosInd);
            this.Controls.Add(this.labelSumPosInd);
            this.Controls.Add(this.MaxAbs);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.MaxInd);
            this.Controls.Add(this.labelMaxInd);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.SumNg);
            this.Controls.Add(this.labelSumNg);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.dataArr);
            this.Controls.Add(this.buttonCount);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(718, 649);
            this.Name = "Form1";
            this.Text = "Завдання 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataGridView dataArr;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSumNg;
        private System.Windows.Forms.Label SumNg;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label MaxInd;
        private System.Windows.Forms.Label labelMaxInd;
        private System.Windows.Forms.Label MaxAbs;
        private System.Windows.Forms.Label labelMaxAbs;
        private System.Windows.Forms.Label SumPosInd;
        private System.Windows.Forms.Label labelSumPosInd;
        private System.Windows.Forms.Label CountInt;
        private System.Windows.Forms.Label labelCountInt;
    }
}

