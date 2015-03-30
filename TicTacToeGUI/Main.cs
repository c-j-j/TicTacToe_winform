using System.Collections.Generic;
using TicTacToe;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public class MainClass
    {
        static public void Main()
        {
            var clickController = new ClickController();
            Application.Run(GameForm.Factory.Build(BuildGame(clickController), clickController));
        }

        static Game BuildGame(ClickController clickController)
        {
            var playerOptions = new Dictionary<string, PlayerFactory>
            {
                { "Human Player", new GUIPlayer.Factory(clickController) },
                { "Computer Player", new ComputerPlayer.Factory() }
            };

            return new GameSetup(new ConsoleUserInput(), playerOptions).CreateGame();
        }
    }
}
