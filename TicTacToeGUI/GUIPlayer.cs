using TicTacToe;

namespace TicTacToeGUI
{
    public class GUIPlayer : Player
    {
        readonly ClickController clickController;
        Mark mark;

        public GUIPlayer(Mark mark, ClickController clickController)
        {
            this.mark = mark;
            this.clickController = clickController;
        }

        public Move GetMove(Game game)
        {
            var move = new Move(mark, clickController.RetrieveClickedPosition());
            clickController.Reset();
            return move;
        }

        public bool Ready()
        {
            return clickController.HasClick();
        }

        public Mark Mark
        {
            get
            {
                return mark;
            }
        }

        public class Factory : PlayerFactory
        {
            readonly ClickController clickController;

            public Factory(ClickController clickController)
            {
                this.clickController = clickController;
            }

            public Player Build(Mark playerMark, Mark opponentMark)
            {
                return new GUIPlayer(playerMark, clickController);
            }
        }
    }
}
