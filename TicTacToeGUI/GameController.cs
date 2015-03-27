using TicTacToe;

public class GameController
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
}
