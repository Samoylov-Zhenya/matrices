
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeterminant
            // 
            this.labelDeterminant.AutoSize = true;
            this.labelDeterminant.Location = new System.Drawing.Point(602, 233);
            this.labelDeterminant.Name = "labelDeterminant";
            this.labelDeterminant.Size = new System.Drawing.Size(64, 13);
            this.labelDeterminant.TabIndex = 17;
            this.labelDeterminant.Text = "Determinant";
            // 
            // RemoveMatrix
            // 
            this.RemoveMatrix.Location = new System.Drawing.Point(665, 134);
            this.RemoveMatrix.Name = "RemoveMatrix";
            this.RemoveMatrix.Size = new System.Drawing.Size(60, 40);
            this.RemoveMatrix.TabIndex = 16;
            this.RemoveMatrix.Text = "Remove matrix";
            this.RemoveMatrix.UseVisualStyleBackColor = true;
            this.RemoveMatrix.Click += new System.EventHandler(this.RemoveMatrix_Click);
            // 
            // buttonDeterminant
            // 
            this.buttonDeterminant.Location = new System.Drawing.Point(605, 180);
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
            this.label1.Location = new System.Drawing.Point(602, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "rows";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(659, 102);
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
            this.CreateMatrix.Location = new System.Drawing.Point(604, 134);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(60, 40);
            this.CreateMatrix.TabIndex = 10;
            this.CreateMatrix.Text = "Create matrix";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDeterminant);
            this.Controls.Add(this.RemoveMatrix);
            this.Controls.Add(this.buttonDeterminant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CreateMatrix);
            this.Name = "Form1";
            this.Text = "matrices";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeterminant;
        private System.Windows.Forms.Button RemoveMatrix;
        private System.Windows.Forms.Button buttonDeterminant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button CreateMatrix;
    }
}

