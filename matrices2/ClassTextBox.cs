using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices2
{
    class ClassTextBox
    {
        public int rows { get; set; }
        public int columns { get; set; }

        public TextBox[,] textBoxArr;

        #region --- constructor конструктор ---
        public ClassTextBox(int rows, bool random)//determ
        {
            this.rows = rows;
            textBoxArr = new TextBox[rows, rows];
            creatingDisplayingTextBox(random);
        }
        public ClassTextBox(int rows, int columns, bool random, int matrixNumber)//sum
        {
            this.rows = rows;
            this.columns = columns;
            textBoxArr = new TextBox[rows, columns];
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
                        Location = new Point(i * 51 + 70, k * 14 + 30),
                        
                        BorderStyle = BorderStyle.None,
                        Size = new Size(50, 20),
                        BackColor = Color.Silver,
                        TextAlign = HorizontalAlignment.Center,
                        Text = random == true ? Convert.ToString(rand.Next(10)) : "",
                        TabIndex = 0
                    };
                }
            }
        }
        void creatingDisplayingTextBoxSum(int matrixNumber, bool random = false)
        {
            var rand = new Random();
            for (int i = 0; i < rows ; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    textBoxArr[i, k] = new System.Windows.Forms.TextBox
                    {
                        Location = new Point(k * 51 + 70, matrixNumber == 1 ? i * 14 + 30 : 
                                                                              i * 14 + 260),
                        BorderStyle = BorderStyle.None,
                        Size = new Size(50, 20),
                        BackColor = Color.Silver,
                        TextAlign = HorizontalAlignment.Center,
                        Text = random == true ? Convert.ToString(rand.Next(10)) : "",
                        TabIndex = 0
                    };
                }
            }
        }
        #endregion
    }
}
