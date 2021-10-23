
namespace Matrices
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOperations = new System.Windows.Forms.Label();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.tabControlOperations = new System.Windows.Forms.TabControl();
            this.tabPageDet = new System.Windows.Forms.TabPage();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelDet = new System.Windows.Forms.Label();
            this.checkBoxDetRandom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSum = new System.Windows.Forms.TabPage();
            this.checkBoxRandomM2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.labelRows = new System.Windows.Forms.Label();
            this.checkBoxRandomM1 = new System.Windows.Forms.CheckBox();
            this.tabPageMultiply = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMultiplyColumn2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownMultiplyRows2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxMultiply2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMultiplyColumn1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultiply1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMultiplyRows1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonOperations = new System.Windows.Forms.Button();
            this.tabControlOperations.SuspendLayout();
            this.tabPageDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.tabPageSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.tabPageMultiply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyRows2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyRows1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Location = new System.Drawing.Point(708, 44);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(65, 15);
            this.labelOperations.TabIndex = 0;
            this.labelOperations.Text = "Operations";
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Items.AddRange(new object[] {
            "det",
            "+",
            "-",
            "*"});
            this.comboBoxOperations.Location = new System.Drawing.Point(808, 41);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOperations.TabIndex = 1;
            this.comboBoxOperations.Text = "det";
            this.comboBoxOperations.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperations_SelectedIndexChanged);
            // 
            // tabControlOperations
            // 
            this.tabControlOperations.Controls.Add(this.tabPageDet);
            this.tabControlOperations.Controls.Add(this.tabPageSum);
            this.tabControlOperations.Controls.Add(this.tabPageMultiply);
            this.tabControlOperations.Location = new System.Drawing.Point(708, 84);
            this.tabControlOperations.Name = "tabControlOperations";
            this.tabControlOperations.SelectedIndex = 0;
            this.tabControlOperations.Size = new System.Drawing.Size(220, 242);
            this.tabControlOperations.TabIndex = 2;
            // 
            // tabPageDet
            // 
            this.tabPageDet.Controls.Add(this.numericUpDownSize);
            this.tabPageDet.Controls.Add(this.labelDet);
            this.tabPageDet.Controls.Add(this.checkBoxDetRandom);
            this.tabPageDet.Controls.Add(this.label2);
            this.tabPageDet.Location = new System.Drawing.Point(4, 24);
            this.tabPageDet.Name = "tabPageDet";
            this.tabPageDet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDet.Size = new System.Drawing.Size(212, 214);
            this.tabPageDet.TabIndex = 0;
            this.tabPageDet.Text = "det";
            this.tabPageDet.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(100, 63);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownSize.TabIndex = 12;
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Location = new System.Drawing.Point(40, 137);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(76, 15);
            this.labelDet.TabIndex = 11;
            this.labelDet.Text = "Determinant:";
            // 
            // checkBoxDetRandom
            // 
            this.checkBoxDetRandom.AutoSize = true;
            this.checkBoxDetRandom.Checked = true;
            this.checkBoxDetRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDetRandom.Location = new System.Drawing.Point(40, 101);
            this.checkBoxDetRandom.Name = "checkBoxDetRandom";
            this.checkBoxDetRandom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDetRandom.Size = new System.Drawing.Size(71, 19);
            this.checkBoxDetRandom.TabIndex = 9;
            this.checkBoxDetRandom.Text = "Random";
            this.checkBoxDetRandom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            // 
            // tabPageSum
            // 
            this.tabPageSum.Controls.Add(this.checkBoxRandomM2);
            this.tabPageSum.Controls.Add(this.label5);
            this.tabPageSum.Controls.Add(this.label4);
            this.tabPageSum.Controls.Add(this.numericUpDownColumn);
            this.tabPageSum.Controls.Add(this.label3);
            this.tabPageSum.Controls.Add(this.numericUpDownRows);
            this.tabPageSum.Controls.Add(this.labelRows);
            this.tabPageSum.Controls.Add(this.checkBoxRandomM1);
            this.tabPageSum.Location = new System.Drawing.Point(4, 24);
            this.tabPageSum.Name = "tabPageSum";
            this.tabPageSum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSum.Size = new System.Drawing.Size(212, 214);
            this.tabPageSum.TabIndex = 1;
            this.tabPageSum.Text = "+ / -";
            this.tabPageSum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandomM2
            // 
            this.checkBoxRandomM2.AutoSize = true;
            this.checkBoxRandomM2.Checked = true;
            this.checkBoxRandomM2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomM2.Location = new System.Drawing.Point(73, 149);
            this.checkBoxRandomM2.Name = "checkBoxRandomM2";
            this.checkBoxRandomM2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRandomM2.Size = new System.Drawing.Size(71, 19);
            this.checkBoxRandomM2.TabIndex = 13;
            this.checkBoxRandomM2.Text = "Random";
            this.checkBoxRandomM2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "M1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "M2";
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Location = new System.Drawing.Point(80, 70);
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownColumn.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Column";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(80, 36);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownRows.TabIndex = 8;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(20, 38);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(35, 15);
            this.labelRows.TabIndex = 6;
            this.labelRows.Text = "Rows";
            // 
            // checkBoxRandomM1
            // 
            this.checkBoxRandomM1.AutoSize = true;
            this.checkBoxRandomM1.Checked = true;
            this.checkBoxRandomM1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomM1.Location = new System.Drawing.Point(73, 126);
            this.checkBoxRandomM1.Name = "checkBoxRandomM1";
            this.checkBoxRandomM1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRandomM1.Size = new System.Drawing.Size(71, 19);
            this.checkBoxRandomM1.TabIndex = 0;
            this.checkBoxRandomM1.Text = "Random";
            this.checkBoxRandomM1.UseVisualStyleBackColor = true;
            // 
            // tabPageMultiply
            // 
            this.tabPageMultiply.Controls.Add(this.label8);
            this.tabPageMultiply.Controls.Add(this.numericUpDownMultiplyColumn2);
            this.tabPageMultiply.Controls.Add(this.label9);
            this.tabPageMultiply.Controls.Add(this.numericUpDownMultiplyRows2);
            this.tabPageMultiply.Controls.Add(this.label10);
            this.tabPageMultiply.Controls.Add(this.checkBoxMultiply2);
            this.tabPageMultiply.Controls.Add(this.label1);
            this.tabPageMultiply.Controls.Add(this.numericUpDownMultiplyColumn1);
            this.tabPageMultiply.Controls.Add(this.checkBoxMultiply1);
            this.tabPageMultiply.Controls.Add(this.label6);
            this.tabPageMultiply.Controls.Add(this.label7);
            this.tabPageMultiply.Controls.Add(this.numericUpDownMultiplyRows1);
            this.tabPageMultiply.Location = new System.Drawing.Point(4, 24);
            this.tabPageMultiply.Name = "tabPageMultiply";
            this.tabPageMultiply.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultiply.Size = new System.Drawing.Size(212, 214);
            this.tabPageMultiply.TabIndex = 2;
            this.tabPageMultiply.Text = "x";
            this.tabPageMultiply.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "M1";
            // 
            // numericUpDownMultiplyColumn2
            // 
            this.numericUpDownMultiplyColumn2.Location = new System.Drawing.Point(82, 170);
            this.numericUpDownMultiplyColumn2.Name = "numericUpDownMultiplyColumn2";
            this.numericUpDownMultiplyColumn2.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownMultiplyColumn2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Column";
            // 
            // numericUpDownMultiplyRows2
            // 
            this.numericUpDownMultiplyRows2.Location = new System.Drawing.Point(82, 136);
            this.numericUpDownMultiplyRows2.Name = "numericUpDownMultiplyRows2";
            this.numericUpDownMultiplyRows2.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownMultiplyRows2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rows";
            // 
            // checkBoxMultiply2
            // 
            this.checkBoxMultiply2.AutoSize = true;
            this.checkBoxMultiply2.Checked = true;
            this.checkBoxMultiply2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMultiply2.Location = new System.Drawing.Point(75, 111);
            this.checkBoxMultiply2.Name = "checkBoxMultiply2";
            this.checkBoxMultiply2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxMultiply2.Size = new System.Drawing.Size(71, 19);
            this.checkBoxMultiply2.TabIndex = 19;
            this.checkBoxMultiply2.Text = "Random";
            this.checkBoxMultiply2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "M1";
            // 
            // numericUpDownMultiplyColumn1
            // 
            this.numericUpDownMultiplyColumn1.Location = new System.Drawing.Point(82, 80);
            this.numericUpDownMultiplyColumn1.Name = "numericUpDownMultiplyColumn1";
            this.numericUpDownMultiplyColumn1.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownMultiplyColumn1.TabIndex = 17;
            // 
            // checkBoxMultiply1
            // 
            this.checkBoxMultiply1.AutoSize = true;
            this.checkBoxMultiply1.Checked = true;
            this.checkBoxMultiply1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMultiply1.Location = new System.Drawing.Point(75, 21);
            this.checkBoxMultiply1.Name = "checkBoxMultiply1";
            this.checkBoxMultiply1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxMultiply1.Size = new System.Drawing.Size(71, 19);
            this.checkBoxMultiply1.TabIndex = 13;
            this.checkBoxMultiply1.Text = "Random";
            this.checkBoxMultiply1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Column";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rows";
            // 
            // numericUpDownMultiplyRows1
            // 
            this.numericUpDownMultiplyRows1.Location = new System.Drawing.Point(82, 46);
            this.numericUpDownMultiplyRows1.Name = "numericUpDownMultiplyRows1";
            this.numericUpDownMultiplyRows1.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownMultiplyRows1.TabIndex = 15;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(708, 469);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create matrix";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(828, 469);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove matrix";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonOperations
            // 
            this.buttonOperations.Location = new System.Drawing.Point(708, 498);
            this.buttonOperations.Name = "buttonOperations";
            this.buttonOperations.Size = new System.Drawing.Size(220, 23);
            this.buttonOperations.TabIndex = 5;
            this.buttonOperations.Text = "Det of matrices";
            this.buttonOperations.UseVisualStyleBackColor = true;
            this.buttonOperations.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 555);
            this.Controls.Add(this.buttonOperations);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.tabControlOperations);
            this.Controls.Add(this.comboBoxOperations);
            this.Controls.Add(this.labelOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlOperations.ResumeLayout(false);
            this.tabPageDet.ResumeLayout(false);
            this.tabPageDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.tabPageSum.ResumeLayout(false);
            this.tabPageSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.tabPageMultiply.ResumeLayout(false);
            this.tabPageMultiply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyRows2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyRows1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.TabControl tabControlOperations;
        private System.Windows.Forms.TabPage tabPageDet;
        private System.Windows.Forms.TabPage tabPageSum;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOperations;
        private System.Windows.Forms.TabPage tabPageMultiply;
        private System.Windows.Forms.CheckBox checkBoxRandomM1;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.CheckBox checkBoxDetRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxRandomM2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiplyColumn2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiplyRows2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxMultiply2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiplyColumn1;
        private System.Windows.Forms.CheckBox checkBoxMultiply1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiplyRows1;
    }
}

