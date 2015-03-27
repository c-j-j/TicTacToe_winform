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
            var clickController = new ClickController();
            var runner = new GameRunner(new Game(new Board(), new GUIPlayer(Mark.X, clickController), new GUIPlayer(Mark.O, clickController)), guiDisplay); 
            var controller = new GameController(new GameRunnerWrapper(runner), clickController);
            gameForm.SetController(controller);
            Application.Run(gameForm);
        }
    }
}
