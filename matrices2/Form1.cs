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
        public Form1()
        {
            InitializeComponent();
        }
        #region --- Class ---
        classTextBox classTextBoxArr;
        class classTextBox
        {
            static public int rows { get; set; }
            //static public int columns { get; set; }
            public TextBox[,] textBoxArr;

            public classTextBox(int rows)
            {
                classTextBox.rows = rows;
                textBoxArr = new TextBox[rows, rows];
                f();

            }
            void f()
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        textBoxArr[i, k] = new System.Windows.Forms.TextBox
                        {
                            Location = new System.Drawing.Point(i * 50 + 70, k * 20 + 30),
                            Name = "textBox2" + i * k,
                            Size = new System.Drawing.Size(50, 20),
                            TabIndex = 0
                        };
                    }
                }
            }
        }
        #endregion
        #region --- Click Add Remove ---
        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            RemoveMatrix_Click(sender, e);
            int rows = (int)numericUpDown1.Value;
            classTextBoxArr = new classTextBox(rows);

            foreach (var item in classTextBoxArr.textBoxArr)
            {
                Controls.Add(item);
            }
        }

        private void RemoveMatrix_Click(object sender, EventArgs e)
        {
            if (classTextBoxArr == null)
            {
                return;
            }
            foreach (var item in classTextBoxArr.textBoxArr)
            {
                Controls.Remove(item);
                //Controls.Add(item);
            }
        }
        #endregion
        #region --- Determinant ---
        private void Determinant_Click(object sender, EventArgs e)
        {
            int rows = classTextBox.rows;
            double[,] matrix = new double[rows, rows];

            for (int i = 0; i < rows; i++)
                for (int k = 0; k < rows; k++)
                    matrix[i, k] = Convert.ToDouble(classTextBoxArr.textBoxArr[k, i].Text);

            TriangularMtrixView(ref matrix);
            labelDeterminant.Text = "Determinant" + Convert.ToString(Determinant(ref matrix));
            Console.WriteLine();
        }
        private double Determinant(ref double[,] matrix)
        {
            double Determinant = 1;
            for (int i = 0, rows = matrix.Length; i < rows; i++)
            {
                Determinant *= matrix[i, i];
            }
            return Determinant;
        }
        private void TriangularMtrixView(ref double[,] matrix)
        {
            int rows = matrix.Length;
            double[,] matrixReturn = new double[rows, rows];
            //cltkfnm kjubre 
            for (int i = 0; i < rows; i++)
            {
                matrixReturn[0, i] = matrix[0, i];
            }
            
            for (int i = 1; i < rows; i++)
            {
                for (int k = 1; k < rows; k++)
                {
                    matrixReturn[0, i] = matrix[0, i];

                }
            }
            return;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
