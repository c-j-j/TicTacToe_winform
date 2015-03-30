using System.Windows.Forms;

namespace TicTacToeGUI
{
    public class Cell : Button
    {
        readonly GameController gameController;
        readonly int position;

        public Cell(GameController gameController, int position)
        {
            this.gameController = gameController;
            this.position = position;
            this.Click += InvokeGameController;
        }

        void InvokeGameController(object sender, System.EventArgs e)
        {
            gameController.CellClicked(position);
        }
    }
}
