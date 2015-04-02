using TicTacToe;

namespace TicTacToeGUI
{
    public class GameController
    {
        readonly GameRunner gameRunner;
        GUIPlayer currentGUIPlayer;

        //used by mocking libraries
        public GameController()
        {

        }

        public GameController(GameRunner gameRunner)
        {
            this.gameRunner = gameRunner;
        }

        public virtual void Start()
        {
            gameRunner.Run();
        }

        public virtual void CellClicked(int position)
        {
            SetPositionOnCurrentGUIPlayer(position);
            gameRunner.Run();
        }

        public void SetPositionOnCurrentGUIPlayer(int position)
        {
            currentGUIPlayer = CurrentPlayer() as GUIPlayer;
            if (currentGUIPlayer != null)
            {
                currentGUIPlayer.SetNextPosition(position);
            }
        }

        Player CurrentPlayer()
        {
            var variable = gameRunner.CurrentPlayer();
            return variable;
        }
    }
}
