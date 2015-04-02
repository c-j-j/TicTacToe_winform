using TicTacToe;

namespace TicTacToeGUI
{
    public class GUIPlayer : Player
    {
        Mark mark;
        public readonly static int WAITING = -1;

        public GUIPlayer(Mark mark)
        {
            this.mark = mark;
            NextPosition = WAITING;
        }

        public Move GetMove(Game game)
        {
            var move = new Move(mark, NextPosition);
            NextPosition = WAITING;
            return move;
        }

        public int NextPosition
        {
            get;
            private set;
        }

        public void SetNextPosition(int position)
        {
            NextPosition = position;
        }

        public bool Ready()
        {
            return NextPosition != WAITING;
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
            public Player Build(Mark playerMark, Mark opponentMark)
            {
                return new GUIPlayer(playerMark);
            }
        }
    }
}
