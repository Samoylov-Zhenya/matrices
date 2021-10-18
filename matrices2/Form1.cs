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
        #region --- Class ---
        classTextBox DeterminantOfMatrix;
        classTextBox sumOfMatrix1;
        classTextBox sumOfMatrix2;

        /*class classTextBox
        {
            static public int rows { get; set; }
            //static public int columns { get; set; }
            public TextBox[,] textBoxArr;
            public classTextBox(int rows)
            {
                classTextBox.rows = rows;
                textBoxArr = new TextBox[rows, rows];
                creatingDisplayingTextBox();

            }
            //создание и вывод Text Box
            void creatingDisplayingTextBox()
            {
                var rand = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        textBoxArr[i, k] = new System.Windows.Forms.TextBox
                        {
                            Location = new Point(i * 50 + 70, k * 20 + 30),
                            Name = "textBox2" + i * k,
                            Size = new Size(50, 20),
                            Text = Convert.ToString(rand.Next(10)),
                            TabIndex = 0
                        };
                    }
                }
            }
        }*/
        #endregion
        #region --- Click Remove ---
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

        #region --- Click Add (Determinant) ---
        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            int rows = (int)numericUpDownRowsDeterminant.Value;
            DeterminantOfMatrix = new classTextBox(rows, checkBoxRandomDeterminant.Checked);

            foreach (var item in DeterminantOfMatrix.textBoxArr)
            {
                Controls.Add(item);
            }
        }
        #endregion
        #region --- Determinant Click---
        private void buttonDeterminant_Click(object sender, EventArgs e)
        {
            int rows = DeterminantOfMatrix.rows;
            double[,] matrix = new double[rows, rows];

            for (int i = 0; i < rows; i++)
                for (int k = 0; k < rows; k++)
                    matrix[i, k] = Convert.ToDouble(DeterminantOfMatrix.textBoxArr[k, i].Text);

            labelDeterminant.Text = "Determinant: " + Convert.ToString(Determinant(matrix));
            Console.WriteLine(Determinant(matrix));
        }
        #endregion
        #region --- Determinant ---
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

        #region --- Sum ---
        private void buttonSum_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region --- Click Add (Sum) ---
        private void buttonCreateSum_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            #region --- rows and column---
            int rows1 = (int)numericUpDownRowsSum1.Value;
            int column1 = (int)numericUpDownColumnSum1.Value;

            int rows2 = (int)numericUpDownRowsSum2.Value;
            int column2 = (int)numericUpDownColumnSum2.Value;
            #endregion

            sumOfMatrix1 = new classTextBox(rows1, column1, checkBoxRandom1Sum.Checked, 1);
            sumOfMatrix2 = new classTextBox(rows2, column2, checkBoxRandom2Sum.Checked, 2);

            #region --- Add TextBox on form ---
            foreach (var item in sumOfMatrix1.textBoxArr)
            {
                Controls.Add(item);
            }
            foreach (var item in sumOfMatrix2.textBoxArr)
            {
                Controls.Add(item);
            }
            #endregion
            Console.WriteLine();
        }

        #endregion

    }
}