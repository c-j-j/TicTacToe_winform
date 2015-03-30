using TicTacToe;

namespace TicTacToeGUI
{
    public class GameFormAdapter : Display
    {
        readonly GameForm gameForm;

        public GameFormAdapter(GameForm gameForm)
        {
            this.gameForm = gameForm;
        }

        public override void PrintMessage(string message)
        {
            gameForm.PrintMessage(message);
        }

        public override void PrintBoard(Board board)
        {
            gameForm.PrintBoard(board);
        }
    }
}
