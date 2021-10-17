using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices2
{
    class classTextBox
    {
        static public int rows { get; set; }
        static public int columns { get; set; }

        public TextBox[,] textBoxArr;
        #region --- constructor конструктор ---
        public classTextBox(int rows, bool random)//determ
        {
            classTextBox.rows = rows;
            textBoxArr = new TextBox[rows, rows];
            creatingDisplayingTextBox(random);
        }
        public classTextBox(int rows, int columns, bool random, int matrixNumber)//sum
        {
            classTextBox.rows = rows;
            classTextBox.columns = columns;
            textBoxArr = new TextBox[columns, rows];
            creatingDisplayingTextBoxSum(matrixNumber, random);
        }
        #endregion

        #region --- methods методы ---
        //создание и вывод Text Box
        void creatingDisplayingTextBox(bool random = false)
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
                        Text = random == true ? Convert.ToString(rand.Next(10)) : "",
                        TabIndex = 0
                    };
                }
            }
        }
        void creatingDisplayingTextBoxSum(int matrixNumber, bool random = false)
        {
            var rand = new Random();
            for (int i = 0; i < columns; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    textBoxArr[i, k] = new System.Windows.Forms.TextBox
                    {
                        Location = new Point(i * 50 + 70, matrixNumber == 1 ? k * 20 + 30 : k * 20 + 260),
                        Name = "textBox2" + i * k,
                        Size = new Size(50, 20),
                        Text = random == true ? Convert.ToString(rand.Next(10)) : "",
                        TabIndex = 0
                    };
                }
            }
        }
        #endregion
    }
}
