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
        #region --- Click Add Determinant ---
        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            int rows = (int)numericUpDownRowsDeterminant.Value;
            DeterminantOfMatrix = new classTextBox(rows , checkBoxRandom.Checked);

            foreach (var item in DeterminantOfMatrix.textBoxArr)
            {
                Controls.Add(item);
            }
        }
        #endregion
        #region --- Click Add Determinant ---
        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region --- Determinant --- не работает 
        private void Determinant_Click(object sender, EventArgs e)
        {
            int rows = classTextBox.rows;
            double[,] matrix = new double[rows, rows];

            for (int i = 0; i < rows; i++)
                for (int k = 0; k < rows; k++)
                    matrix[i, k] = Convert.ToDouble(DeterminantOfMatrix.textBoxArr[k, i].Text);


            //TriangularMtrixView(ref matrix);
            //labelDeterminant.Text = "Determinant" + Convert.ToString(DeterminantComputationPrint(ref matrix));
            labelDeterminant.Text = "Determinant: " + Convert.ToString(Determinant(matrix));
            Console.WriteLine(Determinant(matrix));
        }
        private double DeterminantComputationPrint(ref double[,] matrix)
        {
            double Determinant = 1;
            int rows = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < rows; i++)
            {
                Determinant *= matrix[i, i];
            }
            return Determinant;
        }
        private void TriangularMtrixView(ref double[,] matrix)
        {
            int rows = (int)Math.Sqrt(matrix.Length);
            double[,] matrixReturn = new double[rows, rows];
            #region --- Filling the array ---
            //заполнение массива
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    matrixReturn[i, k] = matrix[i, k];
                }
            }

            #endregion
            double kq;
            for (int i = 0; i < rows-1; i++)
            {
                kq = matrixReturn[i + 1, i] / matrixReturn[i, i];
                for (int n = 0; n < rows; n++)
                {
                    matrixReturn[i + 1, n] = matrixReturn[i + 1, n] - matrixReturn[i, n] * kq;
                    //matrixReturn[n, i + 1] = matrixReturn[n, i + 1] - matrixReturn[n, i] * kq;
                    //matrix[i, n] = Convert.ToDouble(classTextBoxArr.textBoxArr[i, n].Text);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    matrix[i, k] = matrixReturn[i, k];
                }
            }
            return;
        }
        #endregion
        #region --- Determinant2 ---
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

        
        
    }
}
