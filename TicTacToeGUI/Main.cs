using TicTacToe;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public class MainClass
    {
        static public void Main()
        {
            var gameForm = new GameForm();
            var guiDisplay = new GameFormAdapter(gameForm);
            var controller = new GameController(guiDisplay);
            gameForm.SetController(controller);
            Application.Run(gameForm);
        }
    }
}
