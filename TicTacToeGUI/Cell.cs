using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public class Cell : Button
    {
        public Cell(int position)
        {
            this.Location = new Point(15, 15);
            this.Text = position.ToString();
        }
    }
}
