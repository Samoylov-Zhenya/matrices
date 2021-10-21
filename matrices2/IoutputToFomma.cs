using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices2
{
    interface IoutputToFomma
    {
        Label label { get; set; }
        TextBox[,] textBoxArr { get; set; }
    }
}
