using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices2
{
    public partial class Form1 : Form
    {
        #region ---  ---
        #endregion

        #region --- Form ---
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region --- классы Class ---
        matrix Matrix1;
        matrix Matrix2;
        #endregion
        #region --- удаление матриц Click Remove ---
        private void RemoveMatrix_Click(object sender, EventArgs e)
        {
            if (Matrix1 != null)
            {
                foreach (var item in Matrix1.textBoxArr)
                {
                    Controls.Remove(item);
                }
            }
            if (Matrix1 != null)
            {
                foreach (var item in Matrix1.textBoxArr)
                {
                    Controls.Remove(item);
                }
            }
            if (Matrix2 != null)
            {
                foreach (var item in Matrix2.textBoxArr)
                {
                    Controls.Remove(item);
                }
            }
        }
        #endregion

        private void buttonCreateOperations_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            switch (comboBoxOperations.Text)
            {
                case "det":
                    buttonCreateDet();
                    break;
                case "+":
                    buttonCreateSD();
                    break;
                case "-":
                    buttonCreateSD();
                    break;
                case "*":
                    buttonCreateM();
                    break;

                default:
                    break;
            }
        }
        private void buttonCreateM()
        {
            int rows1 = (int)(numericUpDownRows1.Value);
            int column1 = (int)(numericUpDownColumn1.Value);
            int rows2 = (int)(numericUpDownRows2.Value);
            int column2 = (int)(numericUpDownColumn2.Value);

            if (rows1 != column2)
            {
                messageBox("rows1 != column2");
                return;
            }
            Matrix1 = new matrix(rows1, column1, checkBoxRandom1Sum.Checked, 1);
            Matrix2 = new matrix(rows2, column2, checkBoxRandom2Sum.Checked, 2);

            Adds(Matrix1);
            Adds(Matrix2);
        }
        private void buttonCreateSD()
        {
            int rows = (int)numericUpDownRows.Value;
            int column = (int)numericUpDownColumn.Value;

            Matrix1 = new matrix(rows, column, checkBoxRandom1Sum.Checked, 1);
            Matrix2 = new matrix(rows, column, checkBoxRandom2Sum.Checked, 2);

            Adds(Matrix1);
            Adds(Matrix2);
        }
        private void buttonCreateDet()
        {
            int rows = (int)numericUpDownRowsDeterminant.Value;
            Matrix1 = new matrix(rows, checkBoxRandomDeterminant.Checked);

            Adds(Matrix1);
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            switch (comboBoxOperations.Text)
            {
                case "det":
                    detStart();
                    break;
                case "+":
                    sumStart();
                    break;
                case "-":
                    differenceStart();
                    break;
                case "*":
                    multiplyStart();
                    break;

                default:
                    break;
            }
        }
        #region --- Start ---
        private void detStart()
        {
            if (Matrix1 == null)
            {
                messageBox("МАТРИЦА НЕ СОЗДАНА");
                return;
            }
            int rows = Matrix1.rows;
            double[,] matrix = new double[rows, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    matrix[i, k] = Convert.ToDouble(Matrix1.textBoxArr[k, i].Text);
                }
            }

            //labelDeterminant.Text = "Determinant: " + Convert.ToString(Determinant(matrix));
            //Console.WriteLine(Determinant(matrix));
        }
        private void sumStart()
        {
            sum();
        }
        private void differenceStart()
        {
            difference();
        }
        private void multiplyStart()
        {
            int rows1 = (int)(numericUpDownRows1.Value);
            int column1 = (int)(numericUpDownColumn1.Value);
            int rows2 = (int)(numericUpDownRows2.Value);
            int column2 = (int)(numericUpDownColumn2.Value);

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    for (int k = 0; k < rows2; k++)
                    {
                        Matrix1.textBoxArr[i, k].Text = Convert.ToString(
                            int.Parse(Matrix1.textBoxArr[i, k].Text) +
                            int.Parse(Matrix1.textBoxArr[i, k].Text) *
                            int.Parse(Matrix2.textBoxArr[k, j].Text));
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion



        #region --- functions ---
        private void messageBox(string message)
        {
            MessageBox.Show(
                message,
                 "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
        }
        private void Adds(matrix classTextBox)
        {
            Controls.Add(classTextBox.label);

            foreach (var item in classTextBox.textBoxArr)
            {
                Controls.Add(item);
            }
        }
        #endregion
        private void comboBoxOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxOperations.Text)
            {
                case "+":
                    tabControlOperations.SelectedTab = tabPageSum;
                    buttonOperations.Text = "Sum of matrices";
                    break;
                case "-":
                    tabControlOperations.SelectedTab = tabPageSum;
                    buttonOperations.Text = "Difference of matrices";
                    break;
                case "*":
                    tabControlOperations.SelectedTab = tabPageMultiply;
                    buttonOperations.Text = "Multiply of matrices";
                    break;
                case "det":
                    tabControlOperations.SelectedTab = tabPageDeterminant;
                    buttonOperations.Text = "Det of matrices";
                    break;

                default:
                    messageBox("неправильная операция");
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region --- Multiply ---
        #endregion
        
        #region --- Sum and difference ---

        private void difference()
        {
            int rows = (int)(numericUpDownRows.Value);
            int column = (int)(numericUpDownColumn.Value);
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    Matrix1.textBoxArr[i, k].Text =
                        Convert.ToString(
                        int.Parse(Matrix1.textBoxArr[i, k].Text) -
                        int.Parse(Matrix2.textBoxArr[i, k].Text)
                        );
                }
            }
            Adds(Matrix1);
        }
        private void sum()
        {
            int rows = (int)(numericUpDownRows.Value);
            int column = (int)(numericUpDownColumn.Value);
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    Matrix1.textBoxArr[i, k].Text = Convert.ToString(
                        int.Parse(Matrix1.textBoxArr[i, k].Text) +
                        int.Parse(Matrix2.textBoxArr[i, k].Text)
                        );
                }
            }
            Adds(Matrix1);
        }

        #endregion
    }
}