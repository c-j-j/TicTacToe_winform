using TicTacToe;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public class MainClass
    {
        static public void Main()
        {
            Application.Run(GameFormFactory.Build());
        }
    }
}
