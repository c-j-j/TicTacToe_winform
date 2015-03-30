using TicTacToe;

namespace TicTacToeGUI
{
    public class GameController
    {
        readonly GameRunnerWrapper gameRunnerWrapper;
        readonly ClickController clickController;

        //used by mocking libraries
        public GameController()
        {

        }

        public GameController(GameRunnerWrapper gameRunnerWrapper,
            ClickController clickController)
        {
            this.clickController = clickController;
            this.gameRunnerWrapper = gameRunnerWrapper;
        }

        public virtual void Start()
        {
            gameRunnerWrapper.Run();
        }

        public virtual void CellClicked(int position)
        {
            clickController.AddClickEvent(position);
            gameRunnerWrapper.Run();
        }
    }
}
