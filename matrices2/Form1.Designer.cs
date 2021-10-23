
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
            this.tabControlOperations = new System.Windows.Forms.TabControl();
            this.tabPageDeterminant = new System.Windows.Forms.TabPage();
            this.checkBoxRandomDeterminant = new System.Windows.Forms.CheckBox();
            this.tabPageSum = new System.Windows.Forms.TabPage();
            this.checkBoxRandom2Sum = new System.Windows.Forms.CheckBox();
            this.checkBoxRandom1Sum = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownColumnSum1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRowsSum1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.buttonCreateSum = new System.Windows.Forms.Button();
            this.buttonRemoveSum = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageMultiply = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsDeterminant)).BeginInit();
            this.tabControlOperations.SuspendLayout();
            this.tabPageDeterminant.SuspendLayout();
            this.tabPageSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnSum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsSum1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeterminant
            // 
            this.labelDeterminant.AutoSize = true;
            this.labelDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeterminant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.labelDeterminant.Location = new System.Drawing.Point(26, 101);
            this.labelDeterminant.Name = "labelDeterminant";
            this.labelDeterminant.Size = new System.Drawing.Size(116, 24);
            this.labelDeterminant.TabIndex = 17;
            this.labelDeterminant.Text = "Determinant:";
            // 
            // buttonRemoveMatrix
            // 
            this.buttonRemoveMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.buttonRemoveMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRemoveMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveMatrix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveMatrix.FlatAppearance.BorderSize = 0;
            this.buttonRemoveMatrix.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveMatrix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveMatrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.buttonRemoveMatrix.Location = new System.Drawing.Point(96, 139);
            this.buttonRemoveMatrix.Name = "buttonRemoveMatrix";
            this.buttonRemoveMatrix.Size = new System.Drawing.Size(90, 40);
            this.buttonRemoveMatrix.TabIndex = 16;
            this.buttonRemoveMatrix.Text = "Remove matrix";
            this.buttonRemoveMatrix.UseVisualStyleBackColor = false;
            this.buttonRemoveMatrix.Click += new System.EventHandler(this.RemoveMatrix_Click);
            // 
            // buttonDeterminant
            // 
            this.buttonDeterminant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.buttonDeterminant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeterminant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeterminant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeterminant.FlatAppearance.BorderSize = 0;
            this.buttonDeterminant.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeterminant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeterminant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeterminant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeterminant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.buttonDeterminant.Location = new System.Drawing.Point(598, 472);
            this.buttonDeterminant.Name = "buttonDeterminant";
            this.buttonDeterminant.Size = new System.Drawing.Size(180, 68);
            this.buttonDeterminant.TabIndex = 15;
            this.buttonDeterminant.Text = "Determinant of the matrix";
            this.buttonDeterminant.UseVisualStyleBackColor = false;
            this.buttonDeterminant.Click += new System.EventHandler(this.buttonDeterminant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rows";
            // 
            // numericUpDownRowsDeterminant
            // 
            this.numericUpDownRowsDeterminant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.numericUpDownRowsDeterminant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownRowsDeterminant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownRowsDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRowsDeterminant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.numericUpDownRowsDeterminant.Location = new System.Drawing.Point(85, 35);
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
            this.numericUpDownRowsDeterminant.Size = new System.Drawing.Size(42, 25);
            this.numericUpDownRowsDeterminant.TabIndex = 11;
            this.numericUpDownRowsDeterminant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRowsDeterminant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCreateMatrix
            // 
            this.buttonCreateMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.buttonCreateMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCreateMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateMatrix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateMatrix.FlatAppearance.BorderSize = 0;
            this.buttonCreateMatrix.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateMatrix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateMatrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.buttonCreateMatrix.Location = new System.Drawing.Point(6, 139);
            this.buttonCreateMatrix.Name = "buttonCreateMatrix";
            this.buttonCreateMatrix.Size = new System.Drawing.Size(90, 40);
            this.buttonCreateMatrix.TabIndex = 10;
            this.buttonCreateMatrix.Text = "Create matrix";
            this.buttonCreateMatrix.UseVisualStyleBackColor = false;
            this.buttonCreateMatrix.Click += new System.EventHandler(this.buttonCreateMatrix_Click);
            // 
            // tabControlOperations
            // 
            this.tabControlOperations.Controls.Add(this.tabPageDeterminant);
            this.tabControlOperations.Controls.Add(this.tabPageSum);
            this.tabControlOperations.Controls.Add(this.tabPageMultiply);
            this.tabControlOperations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlOperations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlOperations.ItemSize = new System.Drawing.Size(70, 24);
            this.tabControlOperations.Location = new System.Drawing.Point(589, 88);
            this.tabControlOperations.Multiline = true;
            this.tabControlOperations.Name = "tabControlOperations";
            this.tabControlOperations.Padding = new System.Drawing.Point(2, 0);
            this.tabControlOperations.SelectedIndex = 0;
            this.tabControlOperations.Size = new System.Drawing.Size(200, 238);
            this.tabControlOperations.TabIndex = 18;
            // 
            // tabPageDeterminant
            // 
            this.tabPageDeterminant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.tabPageDeterminant.Controls.Add(this.checkBoxRandomDeterminant);
            this.tabPageDeterminant.Controls.Add(this.buttonCreateMatrix);
            this.tabPageDeterminant.Controls.Add(this.labelDeterminant);
            this.tabPageDeterminant.Controls.Add(this.buttonRemoveMatrix);
            this.tabPageDeterminant.Controls.Add(this.numericUpDownRowsDeterminant);
            this.tabPageDeterminant.Controls.Add(this.label1);
            this.tabPageDeterminant.Location = new System.Drawing.Point(4, 28);
            this.tabPageDeterminant.Name = "tabPageDeterminant";
            this.tabPageDeterminant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeterminant.Size = new System.Drawing.Size(192, 206);
            this.tabPageDeterminant.TabIndex = 0;
            this.tabPageDeterminant.Text = "Det";
            // 
            // checkBoxRandomDeterminant
            // 
            this.checkBoxRandomDeterminant.AutoSize = true;
            this.checkBoxRandomDeterminant.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRandomDeterminant.Checked = true;
            this.checkBoxRandomDeterminant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomDeterminant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRandomDeterminant.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxRandomDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRandomDeterminant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.checkBoxRandomDeterminant.Location = new System.Drawing.Point(26, 70);
            this.checkBoxRandomDeterminant.Name = "checkBoxRandomDeterminant";
            this.checkBoxRandomDeterminant.Size = new System.Drawing.Size(101, 28);
            this.checkBoxRandomDeterminant.TabIndex = 18;
            this.checkBoxRandomDeterminant.Text = "Random";
            this.checkBoxRandomDeterminant.UseVisualStyleBackColor = true;
            // 
            // tabPageSum
            // 
            this.tabPageSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.tabPageSum.Controls.Add(this.checkBoxRandom2Sum);
            this.tabPageSum.Controls.Add(this.checkBoxRandom1Sum);
            this.tabPageSum.Controls.Add(this.label7);
            this.tabPageSum.Controls.Add(this.label8);
            this.tabPageSum.Controls.Add(this.numericUpDownColumnSum1);
            this.tabPageSum.Controls.Add(this.label4);
            this.tabPageSum.Controls.Add(this.label3);
            this.tabPageSum.Controls.Add(this.numericUpDownRowsSum1);
            this.tabPageSum.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageSum.Location = new System.Drawing.Point(4, 28);
            this.tabPageSum.Name = "tabPageSum";
            this.tabPageSum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSum.Size = new System.Drawing.Size(192, 206);
            this.tabPageSum.TabIndex = 1;
            this.tabPageSum.Text = "+ / - ";
            // 
            // checkBoxRandom2Sum
            // 
            this.checkBoxRandom2Sum.AutoSize = true;
            this.checkBoxRandom2Sum.Checked = true;
            this.checkBoxRandom2Sum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandom2Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRandom2Sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.checkBoxRandom2Sum.Location = new System.Drawing.Point(85, 45);
            this.checkBoxRandom2Sum.Name = "checkBoxRandom2Sum";
            this.checkBoxRandom2Sum.Size = new System.Drawing.Size(101, 28);
            this.checkBoxRandom2Sum.TabIndex = 19;
            this.checkBoxRandom2Sum.Text = "Random";
            this.checkBoxRandom2Sum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandom1Sum
            // 
            this.checkBoxRandom1Sum.AutoSize = true;
            this.checkBoxRandom1Sum.Checked = true;
            this.checkBoxRandom1Sum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandom1Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRandom1Sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.checkBoxRandom1Sum.Location = new System.Drawing.Point(85, 11);
            this.checkBoxRandom1Sum.Name = "checkBoxRandom1Sum";
            this.checkBoxRandom1Sum.Size = new System.Drawing.Size(101, 28);
            this.checkBoxRandom1Sum.TabIndex = 19;
            this.checkBoxRandom1Sum.Text = "Random";
            this.checkBoxRandom1Sum.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(7, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Matrix 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Matrix 2";
            // 
            // numericUpDownColumnSum1
            // 
            this.numericUpDownColumnSum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.numericUpDownColumnSum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownColumnSum1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownColumnSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownColumnSum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.numericUpDownColumnSum1.Location = new System.Drawing.Point(96, 110);
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
            this.numericUpDownColumnSum1.Size = new System.Drawing.Size(67, 25);
            this.numericUpDownColumnSum1.TabIndex = 25;
            this.numericUpDownColumnSum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownColumnSum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rows";
            // 
            // numericUpDownRowsSum1
            // 
            this.numericUpDownRowsSum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.numericUpDownRowsSum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownRowsSum1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownRowsSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRowsSum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.numericUpDownRowsSum1.Location = new System.Drawing.Point(96, 79);
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
            this.numericUpDownRowsSum1.Size = new System.Drawing.Size(67, 25);
            this.numericUpDownRowsSum1.TabIndex = 20;
            this.numericUpDownRowsSum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRowsSum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(588, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Operations";
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.comboBoxOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Items.AddRange(new object[] {
            "det",
            "+",
            "-",
            "*"});
            this.comboBoxOperations.Location = new System.Drawing.Point(717, 50);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(71, 32);
            this.comboBoxOperations.TabIndex = 33;
            this.comboBoxOperations.Text = "+";
            this.comboBoxOperations.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperations_SelectedIndexChanged);
            // 
            // buttonCreateSum
            // 
            this.buttonCreateSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.buttonCreateSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCreateSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateSum.FlatAppearance.BorderSize = 0;
            this.buttonCreateSum.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateSum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.buttonCreateSum.Location = new System.Drawing.Point(598, 426);
            this.buttonCreateSum.Name = "buttonCreateSum";
            this.buttonCreateSum.Size = new System.Drawing.Size(90, 40);
            this.buttonCreateSum.TabIndex = 19;
            this.buttonCreateSum.Text = "Create matrix";
            this.buttonCreateSum.UseVisualStyleBackColor = false;
            this.buttonCreateSum.Click += new System.EventHandler(this.buttonCreateSum_Click);
            // 
            // buttonRemoveSum
            // 
            this.buttonRemoveSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.buttonRemoveSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRemoveSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveSum.FlatAppearance.BorderSize = 0;
            this.buttonRemoveSum.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveSum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.buttonRemoveSum.Location = new System.Drawing.Point(688, 426);
            this.buttonRemoveSum.Name = "buttonRemoveSum";
            this.buttonRemoveSum.Size = new System.Drawing.Size(90, 40);
            this.buttonRemoveSum.TabIndex = 23;
            this.buttonRemoveSum.Text = "Remove matrix";
            this.buttonRemoveSum.UseVisualStyleBackColor = false;
            this.buttonRemoveSum.Click += new System.EventHandler(this.RemoveMatrix_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.buttonSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSum.FlatAppearance.BorderSize = 0;
            this.buttonSum.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.buttonSum.Location = new System.Drawing.Point(412, 472);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(180, 65);
            this.buttonSum.TabIndex = 22;
            this.buttonSum.Text = "Sum of matrices";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Russian"});
            this.comboBox1.Location = new System.Drawing.Point(677, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 32);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.Text = "English";
            this.comboBox1.UseWaitCursor = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(588, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "language";
            // 
            // tabPageMultiply
            // 
            this.tabPageMultiply.Location = new System.Drawing.Point(4, 28);
            this.tabPageMultiply.Name = "tabPageMultiply";
            this.tabPageMultiply.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultiply.Size = new System.Drawing.Size(192, 206);
            this.tabPageMultiply.TabIndex = 2;
            this.tabPageMultiply.Text = "  x";
            this.tabPageMultiply.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.buttonCreateSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOperations);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonRemoveSum);
            this.Controls.Add(this.buttonDeterminant);
            this.Controls.Add(this.tabControlOperations);
            this.Controls.Add(this.buttonSum);
            this.Name = "Form1";
            this.Text = "matrices";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsDeterminant)).EndInit();
            this.tabControlOperations.ResumeLayout(false);
            this.tabPageDeterminant.ResumeLayout(false);
            this.tabPageDeterminant.PerformLayout();
            this.tabPageSum.ResumeLayout(false);
            this.tabPageSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnSum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsSum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeterminant;
        private System.Windows.Forms.Button buttonRemoveMatrix;
        private System.Windows.Forms.Button buttonDeterminant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsDeterminant;
        private System.Windows.Forms.Button buttonCreateMatrix;
        private System.Windows.Forms.TabControl tabControlOperations;
        private System.Windows.Forms.TabPage tabPageDeterminant;
        private System.Windows.Forms.TabPage tabPageSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnSum1;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateSum;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsSum1;
        private System.Windows.Forms.Button buttonRemoveSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxRandomDeterminant;
        private System.Windows.Forms.CheckBox checkBoxRandom2Sum;
        private System.Windows.Forms.CheckBox checkBoxRandom1Sum;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageMultiply;
    }
}

