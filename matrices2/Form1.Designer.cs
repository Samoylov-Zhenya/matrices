
namespace matrices2
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
            this.labelDeterminant = new System.Windows.Forms.Label();
            this.buttonRemoveMatrix = new System.Windows.Forms.Button();
            this.buttonDeterminant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownRowsDeterminant = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateMatrix = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDeterminant = new System.Windows.Forms.TabPage();
            this.checkBoxRandomDeterminant = new System.Windows.Forms.CheckBox();
            this.tabPageSum = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveSum = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateSum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownColumnSum2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRowsSum1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownRowsSum2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumnSum1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRandom1Sum = new System.Windows.Forms.CheckBox();
            this.checkBoxRandom2Sum = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsDeterminant)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageDeterminant.SuspendLayout();
            this.tabPageSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnSum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsSum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsSum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnSum1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeterminant
            // 
            this.labelDeterminant.AutoSize = true;
            this.labelDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeterminant.Location = new System.Drawing.Point(26, 203);
            this.labelDeterminant.Name = "labelDeterminant";
            this.labelDeterminant.Size = new System.Drawing.Size(116, 24);
            this.labelDeterminant.TabIndex = 17;
            this.labelDeterminant.Text = "Determinant:";
            // 
            // buttonRemoveMatrix
            // 
            this.buttonRemoveMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveMatrix.Location = new System.Drawing.Point(96, 104);
            this.buttonRemoveMatrix.Name = "buttonRemoveMatrix";
            this.buttonRemoveMatrix.Size = new System.Drawing.Size(60, 40);
            this.buttonRemoveMatrix.TabIndex = 16;
            this.buttonRemoveMatrix.Text = "Remove matrix";
            this.buttonRemoveMatrix.UseVisualStyleBackColor = true;
            this.buttonRemoveMatrix.Click += new System.EventHandler(this.RemoveMatrix_Click);
            // 
            // buttonDeterminant
            // 
            this.buttonDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeterminant.Location = new System.Drawing.Point(30, 150);
            this.buttonDeterminant.Name = "buttonDeterminant";
            this.buttonDeterminant.Size = new System.Drawing.Size(126, 40);
            this.buttonDeterminant.TabIndex = 15;
            this.buttonDeterminant.Text = "Determinant of the matrix";
            this.buttonDeterminant.UseVisualStyleBackColor = true;
            this.buttonDeterminant.Click += new System.EventHandler(this.Determinant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rows";
            // 
            // numericUpDownRowsDeterminant
            // 
            this.numericUpDownRowsDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRowsDeterminant.Location = new System.Drawing.Point(89, 35);
            this.numericUpDownRowsDeterminant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRowsDeterminant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRowsDeterminant.Name = "numericUpDownRowsDeterminant";
            this.numericUpDownRowsDeterminant.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownRowsDeterminant.TabIndex = 11;
            this.numericUpDownRowsDeterminant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCreateMatrix
            // 
            this.buttonCreateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateMatrix.Location = new System.Drawing.Point(30, 104);
            this.buttonCreateMatrix.Name = "buttonCreateMatrix";
            this.buttonCreateMatrix.Size = new System.Drawing.Size(60, 40);
            this.buttonCreateMatrix.TabIndex = 10;
            this.buttonCreateMatrix.Text = "Create matrix";
            this.buttonCreateMatrix.UseVisualStyleBackColor = true;
            this.buttonCreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDeterminant);
            this.tabControl1.Controls.Add(this.tabPageSum);
            this.tabControl1.Location = new System.Drawing.Point(588, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 475);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPageDeterminant
            // 
            this.tabPageDeterminant.Controls.Add(this.checkBoxRandomDeterminant);
            this.tabPageDeterminant.Controls.Add(this.buttonDeterminant);
            this.tabPageDeterminant.Controls.Add(this.labelDeterminant);
            this.tabPageDeterminant.Controls.Add(this.buttonCreateMatrix);
            this.tabPageDeterminant.Controls.Add(this.buttonRemoveMatrix);
            this.tabPageDeterminant.Controls.Add(this.numericUpDownRowsDeterminant);
            this.tabPageDeterminant.Controls.Add(this.label1);
            this.tabPageDeterminant.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeterminant.Name = "tabPageDeterminant";
            this.tabPageDeterminant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeterminant.Size = new System.Drawing.Size(192, 449);
            this.tabPageDeterminant.TabIndex = 0;
            this.tabPageDeterminant.Text = "Determinant";
            this.tabPageDeterminant.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandomDeterminant
            // 
            this.checkBoxRandomDeterminant.AutoSize = true;
            this.checkBoxRandomDeterminant.Checked = true;
            this.checkBoxRandomDeterminant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRandomDeterminant.Location = new System.Drawing.Point(43, 70);
            this.checkBoxRandomDeterminant.Name = "checkBoxRandomDeterminant";
            this.checkBoxRandomDeterminant.Size = new System.Drawing.Size(101, 28);
            this.checkBoxRandomDeterminant.TabIndex = 18;
            this.checkBoxRandomDeterminant.Text = "Random";
            this.checkBoxRandomDeterminant.UseVisualStyleBackColor = true;
            // 
            // tabPageSum
            // 
            this.tabPageSum.Controls.Add(this.checkBoxRandom2Sum);
            this.tabPageSum.Controls.Add(this.checkBoxRandom1Sum);
            this.tabPageSum.Controls.Add(this.label8);
            this.tabPageSum.Controls.Add(this.label2);
            this.tabPageSum.Controls.Add(this.buttonRemoveSum);
            this.tabPageSum.Controls.Add(this.buttonSum);
            this.tabPageSum.Controls.Add(this.label5);
            this.tabPageSum.Controls.Add(this.buttonCreateSum);
            this.tabPageSum.Controls.Add(this.label7);
            this.tabPageSum.Controls.Add(this.label3);
            this.tabPageSum.Controls.Add(this.numericUpDownColumnSum2);
            this.tabPageSum.Controls.Add(this.label4);
            this.tabPageSum.Controls.Add(this.numericUpDownRowsSum1);
            this.tabPageSum.Controls.Add(this.label6);
            this.tabPageSum.Controls.Add(this.numericUpDownRowsSum2);
            this.tabPageSum.Controls.Add(this.numericUpDownColumnSum1);
            this.tabPageSum.Location = new System.Drawing.Point(4, 22);
            this.tabPageSum.Name = "tabPageSum";
            this.tabPageSum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSum.Size = new System.Drawing.Size(192, 449);
            this.tabPageSum.TabIndex = 1;
            this.tabPageSum.Text = "Sum";
            this.tabPageSum.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Matrix 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Determinant";
            // 
            // buttonRemoveSum
            // 
            this.buttonRemoveSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveSum.Location = new System.Drawing.Point(87, 231);
            this.buttonRemoveSum.Name = "buttonRemoveSum";
            this.buttonRemoveSum.Size = new System.Drawing.Size(89, 40);
            this.buttonRemoveSum.TabIndex = 23;
            this.buttonRemoveSum.Text = "Remove matrix";
            this.buttonRemoveSum.UseVisualStyleBackColor = true;
            this.buttonRemoveSum.Click += new System.EventHandler(this.RemoveMatrix_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new System.Drawing.Point(10, 277);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(166, 40);
            this.buttonSum.TabIndex = 22;
            this.buttonSum.Text = "Sum of matrices";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "column";
            // 
            // buttonCreateSum
            // 
            this.buttonCreateSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateSum.Location = new System.Drawing.Point(10, 231);
            this.buttonCreateSum.Name = "buttonCreateSum";
            this.buttonCreateSum.Size = new System.Drawing.Size(81, 40);
            this.buttonCreateSum.TabIndex = 19;
            this.buttonCreateSum.Text = "Create matrix";
            this.buttonCreateSum.UseVisualStyleBackColor = true;
            this.buttonCreateSum.Click += new System.EventHandler(this.buttonCreateSum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Matrix 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "rows";
            // 
            // numericUpDownColumnSum2
            // 
            this.numericUpDownColumnSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownColumnSum2.Location = new System.Drawing.Point(109, 190);
            this.numericUpDownColumnSum2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownColumnSum2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumnSum2.Name = "numericUpDownColumnSum2";
            this.numericUpDownColumnSum2.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownColumnSum2.TabIndex = 29;
            this.numericUpDownColumnSum2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "column";
            // 
            // numericUpDownRowsSum1
            // 
            this.numericUpDownRowsSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRowsSum1.Location = new System.Drawing.Point(109, 42);
            this.numericUpDownRowsSum1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRowsSum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRowsSum1.Name = "numericUpDownRowsSum1";
            this.numericUpDownRowsSum1.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownRowsSum1.TabIndex = 20;
            this.numericUpDownRowsSum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "rows";
            // 
            // numericUpDownRowsSum2
            // 
            this.numericUpDownRowsSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRowsSum2.Location = new System.Drawing.Point(109, 155);
            this.numericUpDownRowsSum2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRowsSum2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRowsSum2.Name = "numericUpDownRowsSum2";
            this.numericUpDownRowsSum2.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownRowsSum2.TabIndex = 27;
            this.numericUpDownRowsSum2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownColumnSum1
            // 
            this.numericUpDownColumnSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownColumnSum1.Location = new System.Drawing.Point(109, 77);
            this.numericUpDownColumnSum1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownColumnSum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumnSum1.Name = "numericUpDownColumnSum1";
            this.numericUpDownColumnSum1.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownColumnSum1.TabIndex = 25;
            this.numericUpDownColumnSum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxRandom1Sum
            // 
            this.checkBoxRandom1Sum.AutoSize = true;
            this.checkBoxRandom1Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRandom1Sum.Location = new System.Drawing.Point(87, 11);
            this.checkBoxRandom1Sum.Name = "checkBoxRandom1Sum";
            this.checkBoxRandom1Sum.Size = new System.Drawing.Size(101, 28);
            this.checkBoxRandom1Sum.TabIndex = 19;
            this.checkBoxRandom1Sum.Text = "Random";
            this.checkBoxRandom1Sum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandom2Sum
            // 
            this.checkBoxRandom2Sum.AutoSize = true;
            this.checkBoxRandom2Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRandom2Sum.Location = new System.Drawing.Point(87, 119);
            this.checkBoxRandom2Sum.Name = "checkBoxRandom2Sum";
            this.checkBoxRandom2Sum.Size = new System.Drawing.Size(101, 28);
            this.checkBoxRandom2Sum.TabIndex = 19;
            this.checkBoxRandom2Sum.Text = "Random";
            this.checkBoxRandom2Sum.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "matrices";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsDeterminant)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDeterminant.ResumeLayout(false);
            this.tabPageDeterminant.PerformLayout();
            this.tabPageSum.ResumeLayout(false);
            this.tabPageSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnSum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsSum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsSum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnSum1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDeterminant;
        private System.Windows.Forms.Button buttonRemoveMatrix;
        private System.Windows.Forms.Button buttonDeterminant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsDeterminant;
        private System.Windows.Forms.Button buttonCreateMatrix;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDeterminant;
        private System.Windows.Forms.TabPage tabPageSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnSum1;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateSum;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsSum1;
        private System.Windows.Forms.Button buttonRemoveSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnSum2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsSum2;
        private System.Windows.Forms.CheckBox checkBoxRandomDeterminant;
        private System.Windows.Forms.CheckBox checkBoxRandom2Sum;
        private System.Windows.Forms.CheckBox checkBoxRandom1Sum;
    }
}

