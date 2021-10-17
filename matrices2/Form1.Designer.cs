
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
            this.RemoveMatrix = new System.Windows.Forms.Button();
            this.buttonDeterminant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDeterminant = new System.Windows.Forms.TabPage();
            this.tabPageSum = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageDeterminant.SuspendLayout();
            this.tabPageSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeterminant
            // 
            this.labelDeterminant.AutoSize = true;
            this.labelDeterminant.Location = new System.Drawing.Point(32, 166);
            this.labelDeterminant.Name = "labelDeterminant";
            this.labelDeterminant.Size = new System.Drawing.Size(64, 13);
            this.labelDeterminant.TabIndex = 17;
            this.labelDeterminant.Text = "Determinant";
            // 
            // RemoveMatrix
            // 
            this.RemoveMatrix.Location = new System.Drawing.Point(95, 67);
            this.RemoveMatrix.Name = "RemoveMatrix";
            this.RemoveMatrix.Size = new System.Drawing.Size(60, 40);
            this.RemoveMatrix.TabIndex = 16;
            this.RemoveMatrix.Text = "Remove matrix";
            this.RemoveMatrix.UseVisualStyleBackColor = true;
            this.RemoveMatrix.Click += new System.EventHandler(this.RemoveMatrix_Click);
            // 
            // buttonDeterminant
            // 
            this.buttonDeterminant.Location = new System.Drawing.Point(35, 113);
            this.buttonDeterminant.Name = "buttonDeterminant";
            this.buttonDeterminant.Size = new System.Drawing.Size(120, 40);
            this.buttonDeterminant.TabIndex = 15;
            this.buttonDeterminant.Text = "Determinant of the matrix";
            this.buttonDeterminant.UseVisualStyleBackColor = true;
            this.buttonDeterminant.Click += new System.EventHandler(this.Determinant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "rows";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.Location = new System.Drawing.Point(34, 67);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(60, 40);
            this.CreateMatrix.TabIndex = 10;
            this.CreateMatrix.Text = "Create matrix";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDeterminant);
            this.tabControl1.Controls.Add(this.tabPageSum);
            this.tabControl1.Location = new System.Drawing.Point(588, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 426);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPageDeterminant
            // 
            this.tabPageDeterminant.Controls.Add(this.buttonDeterminant);
            this.tabPageDeterminant.Controls.Add(this.labelDeterminant);
            this.tabPageDeterminant.Controls.Add(this.CreateMatrix);
            this.tabPageDeterminant.Controls.Add(this.RemoveMatrix);
            this.tabPageDeterminant.Controls.Add(this.numericUpDown1);
            this.tabPageDeterminant.Controls.Add(this.label1);
            this.tabPageDeterminant.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeterminant.Name = "tabPageDeterminant";
            this.tabPageDeterminant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeterminant.Size = new System.Drawing.Size(192, 400);
            this.tabPageDeterminant.TabIndex = 0;
            this.tabPageDeterminant.Text = "Determinant";
            this.tabPageDeterminant.UseVisualStyleBackColor = true;
            // 
            // tabPageSum
            // 
            this.tabPageSum.Controls.Add(this.label8);
            this.tabPageSum.Controls.Add(this.label7);
            this.tabPageSum.Controls.Add(this.label5);
            this.tabPageSum.Controls.Add(this.numericUpDown2);
            this.tabPageSum.Controls.Add(this.label6);
            this.tabPageSum.Controls.Add(this.numericUpDown3);
            this.tabPageSum.Controls.Add(this.label4);
            this.tabPageSum.Controls.Add(this.numericUpDownColumn);
            this.tabPageSum.Controls.Add(this.button1);
            this.tabPageSum.Controls.Add(this.label2);
            this.tabPageSum.Controls.Add(this.label3);
            this.tabPageSum.Controls.Add(this.button2);
            this.tabPageSum.Controls.Add(this.numericUpDownRows);
            this.tabPageSum.Controls.Add(this.button3);
            this.tabPageSum.Location = new System.Drawing.Point(4, 22);
            this.tabPageSum.Name = "tabPageSum";
            this.tabPageSum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSum.Size = new System.Drawing.Size(192, 400);
            this.tabPageSum.TabIndex = 1;
            this.tabPageSum.Text = "Sum";
            this.tabPageSum.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "column";
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Location = new System.Drawing.Point(91, 62);
            this.numericUpDownColumn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownColumn.TabIndex = 25;
            this.numericUpDownColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sum of matrices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Determinant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "rows";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Create matrix";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(91, 36);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownRows.TabIndex = 20;
            this.numericUpDownRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Remove matrix";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "column";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(91, 147);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "rows";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(91, 121);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown3.TabIndex = 27;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Matrix 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Matrix 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "matrices";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDeterminant.ResumeLayout(false);
            this.tabPageDeterminant.PerformLayout();
            this.tabPageSum.ResumeLayout(false);
            this.tabPageSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDeterminant;
        private System.Windows.Forms.Button RemoveMatrix;
        private System.Windows.Forms.Button buttonDeterminant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDeterminant;
        private System.Windows.Forms.TabPage tabPageSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

