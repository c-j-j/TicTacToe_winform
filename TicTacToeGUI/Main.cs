using System.Collections.Generic;
using TicTacToe;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public class MainClass
    {
        static public void Main()
        {
            Application.Run(GameForm.Factory.Build(BuildGame()));
        }

        static Game BuildGame()
        {
            var playerOptions = new Dictionary<string, PlayerFactory>
            {
                { "Human Player", new GUIPlayer.Factory() },
                { "Computer Player", new ComputerPlayer.Factory() }
            };

            return new GameSetup(new ConsoleUserInput(), playerOptions).CreateGame();
        }
    }
}
