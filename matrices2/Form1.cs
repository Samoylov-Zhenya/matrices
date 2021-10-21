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


        #region --- Determinant ---
        #region --- добавить на экран матрицу Click Add (Determinant) ---
        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            int rows = (int)numericUpDownRowsDeterminant.Value;
            Matrix1 = new matrix(rows, checkBoxRandomDeterminant.Checked);

            Adds(Matrix1);
        }
        #endregion
        #region --- Determinant button Click---
        private void buttonDeterminant_Click(object sender, EventArgs e)
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
        #endregion
        #region --- алгоритм ---
        //этот метод определяет знак элементов
        //this method determines the sign of the elements
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
        //этот метод определяет подматрицу, соответствующую данному элементу
        //this method determines the sub matrix corresponding to a given element
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
        //этот метод определяет значение определителя с помощью рекурсии
        //this method determines the value of determinant using recursion
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
        #endregion

        #region --- Sum ---
        private void comboBoxOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sum of matrices
            switch (comboBoxOperations.Text)
            {
                case "+":
                    buttonSum.Text = "Sum of matrices";
                    break;

                default:
                    buttonSum.Text = "Difference of matrices";
                    break;
            }
        }

        #region --- button Sum ---
        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (Matrix1 == null || Matrix2 == null)
            {
                messageBox("МАТРИЦЫ НЕ СОЗДАНЫ");
                return;
            }
            #region --- rows and column---
            int rows = (int)numericUpDownRowsSum1.Value;
            int column = (int)numericUpDownColumnSum1.Value;
            #endregion

            RemoveMatrix_Click(sender, e);
            switch (comboBoxOperations.Text)
            {
                case "+":
                    sum(rows, column);
                    break;

                default:
                    difference(rows, column);
                    break;
            }
        }
        #endregion
        #region --- действия ---
        private void difference(int rows, int column)
        {
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
            Console.WriteLine();
            Adds(Matrix1);
        }
        private void sum(int rows, int column)
        {
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
            Console.WriteLine();
            Adds(Matrix1);
        }
        #endregion
        #region --- textBox Add (Sum) ---
        private void buttonCreateSum_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            #region --- rows and column---
            int rows = (int)numericUpDownRowsSum1.Value;
            int column = (int)numericUpDownColumnSum1.Value;
            #endregion

            Matrix1 = new matrix(rows, column, checkBoxRandom1Sum.Checked, 1);
            Matrix2 = new matrix(rows, column, checkBoxRandom2Sum.Checked, 2);

            #region --- Add TextBox on form ---
            Adds(Matrix1);
            Adds(Matrix2);
            #endregion
            Console.WriteLine();
        }
        #endregion
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}