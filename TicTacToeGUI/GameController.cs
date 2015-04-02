using TicTacToe;

namespace TicTacToeGUI
{
    public class GameController
    {
        readonly GameRunner gameRunner;

        readonly ClickController clickController;

        //used by mocking libraries
        public GameController()
        {

        }

        public GameController(GameRunner gameRunner,
            ClickController clickController)
        {
            this.clickController = clickController;
            this.gameRunner = gameRunner;
        }

        public virtual void Start()
        {
            gameRunner.Run();
        }

        public virtual void CellClicked(int position)
        {
            //game.playMove(position);
            //game.continue();
            clickController.AddClickEvent(position);
            gameRunner.Run();
        }
    }
}
