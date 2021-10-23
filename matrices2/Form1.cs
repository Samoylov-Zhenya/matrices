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
        #region --- ссылки на классы Class ---
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

                default:
                    break;
            }
        }
        private void buttonCreateSD()
        {
            int rows = (int)numericUpDownRowsSum.Value;
            int column = (int)numericUpDownColumnSum.Value;

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

            labelDeterminant.Text = "Determinant: " + Convert.ToString(Determinant(matrix));
            Console.WriteLine(Determinant(matrix));
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
        #region --- Determinant ---
        static int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        static double[,] CreateSmallerMatrix(double[,] matrix, int column, int row)
        {
            int order = int.Parse(System.Math.Sqrt(matrix.Length).ToString());
            double[,] output = new double[order - 1, order - 1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != column)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != row)
                        {
                            output[x, y] = matrix[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
        static double Determinant(double[,] matrix)
        {
            int order = int.Parse(System.Math.Sqrt(matrix.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = CreateSmallerMatrix(matrix, 0, j);
                    value = value + matrix[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]));
            }
            else
            {
                return (matrix[0, 0]);
            }
        }
        #endregion
        #region --- Sum and difference ---

        private void difference()
        {
            int rows = (int)(numericUpDownRowsSum.Value);
            int column = (int)(numericUpDownColumnSum.Value);
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
            int rows = (int)(numericUpDownRowsSum.Value);
            int column = (int)(numericUpDownColumnSum.Value);
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