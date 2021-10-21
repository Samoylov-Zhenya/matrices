using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices2
{
    class matrix : Isize, IoutputToFomma
    {
        public int rows { get; set; }
        public int columns { get; set; }

        public Label label { get; set; }
        public TextBox[,] textBoxArr { get; set; }

        #region --- constructor конструктор ---
        public matrix(int rows, bool random)//determ
        {
            this.rows = rows;
            this.columns = rows;
            textBoxArr = new TextBox[rows, rows];
            creatingDisplayingMatrixTextBox(random);
        }
        public matrix(int rows, int columns, bool random, int matrixNumber)//sum
        {
            this.rows = rows;
            this.columns = columns;
            textBoxArr = new TextBox[rows, columns];
            creatingDisplayingMatrixTextBox(random, matrixNumber);
        }
        #endregion

        #region --- methods методы ---
        //создание Text Box
        /*void creatingDisplayingTextBox(bool random = false)
        {
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
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
        }*/
        void creatingDisplayingMatrixTextBox(bool random = false, int matrixNumber = 1)
        {
            creatingDisplayingLabel(matrixNumber);
            creatingDisplayingTextBox(random, matrixNumber);
        }
        void creatingDisplayingLabel(int matrixNumber)
        {
            label = new Label
            {
                Text = "M" + matrixNumber,
                Location = new Point(20, matrixNumber == 1 ? 24 : 254),
                Font = new Font("Microsoft Sans Serif", 14),
                ForeColor = Color.FromArgb(144, 155, 169),
                Size = new Size(50, 20),
            };
        }
        void creatingDisplayingTextBox(bool random = false, int matrixNumber = 1)
        {
            var rand = new Random();

            for (int i = 0; i < rows; i++)
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
