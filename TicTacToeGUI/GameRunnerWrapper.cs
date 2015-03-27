using TicTacToe;

namespace TicTacToeGUI
{
    public class GameRunnerWrapper
    {
        readonly GameRunner gameRunner;

        public GameRunnerWrapper(GameRunner gameRunner)
        {
            this.gameRunner = gameRunner;
        }

        public virtual void Run()
        {
            gameRunner.Run();
        }
    }
}
