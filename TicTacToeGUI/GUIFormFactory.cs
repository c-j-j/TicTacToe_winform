using TicTacToe;

namespace TicTacToeGUI
{
    public static class GameFormFactory
    {
        public static GameForm Build()
        {
            var clickController = new ClickController();
            var gameForm = new GameForm();
            var guiDisplay = new GameFormAdapter(gameForm);
            var gameRunner = new GameRunner(new Game(new Board(), new GUIPlayer(Mark.X, clickController), new ComputerPlayer(Mark.O, Mark.X)), guiDisplay); 
            var gameController = new GameController(new GameRunnerWrapper(gameRunner), clickController);
            gameForm.SetController(gameController);
            return gameForm;
        }
    }
}
