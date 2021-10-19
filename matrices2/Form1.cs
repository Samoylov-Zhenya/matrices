﻿using System;
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
        ClassTextBox DeterminantOfMatrix;
        ClassTextBox sumOfMatrix1;
        ClassTextBox sumOfMatrix2;
        #endregion
        #region --- удаление матриц Click Remove ---
        private void RemoveMatrix_Click(object sender, EventArgs e)
        {
            if (DeterminantOfMatrix != null)
            {
                foreach (var item in DeterminantOfMatrix.textBoxArr)
                {
                    Controls.Remove(item);
                }
            }
            if (sumOfMatrix1 != null)
            {
                foreach (var item in sumOfMatrix1.textBoxArr)
                {
                    Controls.Remove(item);
                }
            }
            if (sumOfMatrix2 != null)
            {
                foreach (var item in sumOfMatrix2.textBoxArr)
                {
                    Controls.Remove(item);
                }
            }
        }
        #endregion

        #region --- добавить на экран матрицу Click Add (Determinant) ---
        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            int rows = (int)numericUpDownRowsDeterminant.Value;
            DeterminantOfMatrix = new ClassTextBox(rows, checkBoxRandomDeterminant.Checked);

            Adds(DeterminantOfMatrix);
        }
        #endregion
        #region --- алгоритм Determinant ---
        #region --- Determinant button Click---
        private void buttonDeterminant_Click(object sender, EventArgs e)
        {
            int rows = DeterminantOfMatrix.rows;
            double[,] matrix = new double[rows, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    matrix[i, k] = Convert.ToDouble(DeterminantOfMatrix.textBoxArr[k, i].Text);
                }
            }

            labelDeterminant.Text = "Determinant: " + Convert.ToString(Determinant(matrix));
            Console.WriteLine(Determinant(matrix));
        }
        #endregion
        #region ---  ---
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
        private void buttonSum_Click(object sender, EventArgs e)
        {
            #region --- rows and column---
            int rows1 = (int)numericUpDownRowsSum1.Value;
            int column1 = (int)numericUpDownColumnSum1.Value;

            int rows2 = (int)numericUpDownRowsSum2.Value;
            int column2 = (int)numericUpDownColumnSum2.Value;
            #endregion
            if (rows1 != rows2 || column1 != column2)
            {
                MessageBox.Show(
                "НЕ ВСЕ МАТРИЦЫ МОЖНО СКЛАДЫВАТЬ. \n Для выполнения сложения матриц, необходимо, чтобы они были ОДИНАКОВЫМИ ПО РАЗМЕРУ.",
                 "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
            RemoveMatrix_Click(sender, e);
            Sum();
        }
        private void Sum()
        {
            int rows1 = (int)numericUpDownRowsSum1.Value;
            int column1 = (int)numericUpDownColumnSum1.Value;

            for (int i = 0; i < rows1; i++)
            {
                for (int k = 0; k < column1; k++)
                {
                    sumOfMatrix1.textBoxArr[i, k].Text = Convert.ToString(
                        int.Parse(sumOfMatrix1.textBoxArr[i, k].Text) +
                        int.Parse(sumOfMatrix2.textBoxArr[i, k].Text)
                        );
                }
            }
            Adds(sumOfMatrix1);
        }
        #endregion
        #region --- textBox Add (Sum) ---
        private void buttonCreateSum_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            #region --- rows and column---
            int rows1 = (int)numericUpDownRowsSum1.Value;
            int column1 = (int)numericUpDownColumnSum1.Value;

            int rows2 = (int)numericUpDownRowsSum2.Value;
            int column2 = (int)numericUpDownColumnSum2.Value;
            #endregion

            sumOfMatrix1 = new ClassTextBox(rows1, column1, checkBoxRandom1Sum.Checked, 1);
            sumOfMatrix2 = new ClassTextBox(rows2, column2, checkBoxRandom2Sum.Checked, 2);

            #region --- Add TextBox on form ---
            Adds(sumOfMatrix1);
            Adds(sumOfMatrix2);
            #endregion
            Console.WriteLine();
        }
        #endregion
        #region --- Adds ---
        private void Adds(ClassTextBox classTextBox)
        {
            foreach (var item in classTextBox.textBoxArr)
            {
                Controls.Add(item);
            }
        }
        #endregion
    }
}