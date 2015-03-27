using TicTacToe;

namespace TicTacToeGUI
{
    public class GameController : Controller
    {
        readonly GameRunnerWrapper gameRunnerWrapper;
        readonly ClickController clickController;

        public GameController(GameRunnerWrapper gameRunnerWrapper,
            ClickController clickController)
        {
            this.clickController = clickController;
            this.gameRunnerWrapper = gameRunnerWrapper;
        }

        public void Start()
        {
            gameRunnerWrapper.Run();
        }

        public void CellClicked(int position)
        {
            clickController.AddClickEvent(position);
            gameRunnerWrapper.Run();
        }
    }
}
