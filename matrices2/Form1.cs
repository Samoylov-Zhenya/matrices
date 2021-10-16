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
                //Controls.Add(item);
                Controls.Remove(item);
            }
        }
        #endregion
        private void Determinant_Click(object sender, EventArgs e)
        {
            int rows = classTextBox.rows;
            double[,] matrix = new double[rows, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    matrix[i, k] = Convert.ToDouble(classTextBoxArr.textBoxArr[k, i].Text);
                }
            }
            Console.WriteLine();
        }
    }
}
