using TicTacToe;

namespace TicTacToeGUI
{
    public class GameController : Controller
    {
        readonly Display gameView;

        public GameController(Display display)
        {
            this.gameView = display;
        }

        public void Start()
        {
            var runner = new GameRunner(new Game(new Board(), new ComputerPlayer(Mark.X, Mark.O), new ComputerPlayer(Mark.O, Mark.X)), 
                         gameView);
            runner.Run();
        }

        public void CellClicked(int position)
        {
        }
    }
}
