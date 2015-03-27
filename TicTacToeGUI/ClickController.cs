namespace TicTacToeGUI
{
    public class ClickController
    {
        const int UNSET_POSITION = -1;
        int clickedPosition = UNSET_POSITION;

        public virtual void AddClickEvent(int position)
        {
            clickedPosition = position;
        }

        public bool HasClick()
        {
            return clickedPosition != UNSET_POSITION;
        }

        public int RetrieveClickedPosition()
        {
            return clickedPosition;
        }

        public void Reset()
        {
            clickedPosition = UNSET_POSITION;
        }
    }
}
