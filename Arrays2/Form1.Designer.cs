namespace Arrays2
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.dataArr = new System.Windows.Forms.DataGridView();
            this.buttonCount = new System.Windows.Forms.Button();
            this.labelAfterMin = new System.Windows.Forms.Label();
            this.labelSumBetweenNegAndPos = new System.Windows.Forms.Label();
            this.labelSumBetweenZeroElements = new System.Windows.Forms.Label();
            this.labelProdBetweenMaxAndMin = new System.Windows.Forms.Label();
            this.AfterMin = new System.Windows.Forms.Label();
            this.SumBetweenNegAndPos = new System.Windows.Forms.Label();
            this.SumBetweenZeroElements = new System.Windows.Forms.Label();
            this.ProdBetweenMaxAndMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(651, 6);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(140, 34);
            this.buttonCalculate.TabIndex = 28;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Visible = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Enabled = false;
            this.buttonFill.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFill.Location = new System.Drawing.Point(514, 5);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(131, 34);
            this.buttonFill.TabIndex = 27;
            this.buttonFill.Text = "Заповнити";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.ButtonFill_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(313, 9);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(79, 29);
            this.textBoxN.TabIndex = 26;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(13, 9);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(281, 24);
            this.labelN.TabIndex = 25;
            this.labelN.Text = "Введіть кількість елементів:";
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
            this.dataArr.Location = new System.Drawing.Point(13, 57);
            this.dataArr.Margin = new System.Windows.Forms.Padding(4);
            this.dataArr.Name = "dataArr";
            this.dataArr.RowHeadersWidth = 5;
            this.dataArr.Size = new System.Drawing.Size(778, 180);
            this.dataArr.TabIndex = 24;
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(400, 5);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(107, 34);
            this.buttonCount.TabIndex = 23;
            this.buttonCount.Text = "Додати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // labelAfterMin
            // 
            this.labelAfterMin.AutoSize = true;
            this.labelAfterMin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAfterMin.Location = new System.Drawing.Point(17, 284);
            this.labelAfterMin.Name = "labelAfterMin";
            this.labelAfterMin.Size = new System.Drawing.Size(0, 29);
            this.labelAfterMin.TabIndex = 30;
            // 
            // labelSumBetweenNegAndPos
            // 
            this.labelSumBetweenNegAndPos.AutoSize = true;
            this.labelSumBetweenNegAndPos.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumBetweenNegAndPos.Location = new System.Drawing.Point(14, 368);
            this.labelSumBetweenNegAndPos.Name = "labelSumBetweenNegAndPos";
            this.labelSumBetweenNegAndPos.Size = new System.Drawing.Size(0, 29);
            this.labelSumBetweenNegAndPos.TabIndex = 31;
            // 
            // labelSumBetweenZeroElements
            // 
            this.labelSumBetweenZeroElements.AutoSize = true;
            this.labelSumBetweenZeroElements.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumBetweenZeroElements.Location = new System.Drawing.Point(14, 448);
            this.labelSumBetweenZeroElements.Name = "labelSumBetweenZeroElements";
            this.labelSumBetweenZeroElements.Size = new System.Drawing.Size(0, 29);
            this.labelSumBetweenZeroElements.TabIndex = 33;
            // 
            // labelProdBetweenMaxAndMin
            // 
            this.labelProdBetweenMaxAndMin.AutoSize = true;
            this.labelProdBetweenMaxAndMin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProdBetweenMaxAndMin.Location = new System.Drawing.Point(17, 541);
            this.labelProdBetweenMaxAndMin.Name = "labelProdBetweenMaxAndMin";
            this.labelProdBetweenMaxAndMin.Size = new System.Drawing.Size(0, 29);
            this.labelProdBetweenMaxAndMin.TabIndex = 35;
            // 
            // AfterMin
            // 
            this.AfterMin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AfterMin.Location = new System.Drawing.Point(14, 251);
            this.AfterMin.Name = "AfterMin";
            this.AfterMin.Size = new System.Drawing.Size(777, 32);
            this.AfterMin.TabIndex = 36;
            this.AfterMin.Text = "Произведение элементов массива,что расположены после минимального элемента";
            // 
            // SumBetweenNegAndPos
            // 
            this.SumBetweenNegAndPos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumBetweenNegAndPos.Location = new System.Drawing.Point(15, 314);
            this.SumBetweenNegAndPos.Name = "SumBetweenNegAndPos";
            this.SumBetweenNegAndPos.Size = new System.Drawing.Size(777, 58);
            this.SumBetweenNegAndPos.TabIndex = 37;
            this.SumBetweenNegAndPos.Text = "Сума элементов массива, что расположены между первым отрицательным и вторым полож" +
    "ительным элементами";
            // 
            // SumBetweenZeroElements
            // 
            this.SumBetweenZeroElements.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumBetweenZeroElements.Location = new System.Drawing.Point(14, 397);
            this.SumBetweenZeroElements.Name = "SumBetweenZeroElements";
            this.SumBetweenZeroElements.Size = new System.Drawing.Size(777, 55);
            this.SumBetweenZeroElements.TabIndex = 38;
            this.SumBetweenZeroElements.Text = "Сума элементов массива, которые расположены между первым и последним нулевым элем" +
    "ентами";
            // 
            // ProdBetweenMaxAndMin
            // 
            this.ProdBetweenMaxAndMin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdBetweenMaxAndMin.Location = new System.Drawing.Point(10, 484);
            this.ProdBetweenMaxAndMin.Name = "ProdBetweenMaxAndMin";
            this.ProdBetweenMaxAndMin.Size = new System.Drawing.Size(781, 52);
            this.ProdBetweenMaxAndMin.TabIndex = 39;
            this.ProdBetweenMaxAndMin.Text = "Произведение элементов массива, которые расположены между максимальным по модулю " +
    "и минимальным по модулю элементом";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 632);
            this.Controls.Add(this.ProdBetweenMaxAndMin);
            this.Controls.Add(this.SumBetweenZeroElements);
            this.Controls.Add(this.SumBetweenNegAndPos);
            this.Controls.Add(this.AfterMin);
            this.Controls.Add(this.labelProdBetweenMaxAndMin);
            this.Controls.Add(this.labelSumBetweenZeroElements);
            this.Controls.Add(this.labelSumBetweenNegAndPos);
            this.Controls.Add(this.labelAfterMin);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.dataArr);
            this.Controls.Add(this.buttonCount);
            this.MinimumSize = new System.Drawing.Size(718, 649);
            this.Name = "Form1";
            this.Text = "Завдання 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.DataGridView dataArr;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label labelAfterMin;
        private System.Windows.Forms.Label labelSumBetweenNegAndPos;
        private System.Windows.Forms.Label labelSumBetweenZeroElements;
        private System.Windows.Forms.Label labelProdBetweenMaxAndMin;
        private System.Windows.Forms.Label AfterMin;
        private System.Windows.Forms.Label SumBetweenNegAndPos;
        private System.Windows.Forms.Label SumBetweenZeroElements;
        private System.Windows.Forms.Label ProdBetweenMaxAndMin;
    }
}

