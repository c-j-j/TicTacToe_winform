using TicTacToe;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGUI
{
    public class GameForm : Form
    {
        GameController controller;
        BoardPanel boardPanel;
        Label statusLabel;

        const int BOARD_SIZE = 200;
        Point BUTTON_LOCATION = new Point(10, 5);
        Point STATUS_LOCATION = new Point(100, 5);
        Point BOARD_LOCATION = new Point(10, 50);

        public GameForm()
        {
            SetupStatusLabel();
            SetupStartButton();
            CenterToScreen();
        }

        void SetupStartButton()
        {
            var startButton = new Button();
            startButton.Location = BUTTON_LOCATION;
            startButton.Text = "Play Game";
            startButton.Click += StartGame;
            Controls.Add(startButton);
        }

        void SetupStatusLabel()
        {
            statusLabel = new Label();
            statusLabel.Text = "Status label";
            statusLabel.Location = STATUS_LOCATION;
            Controls.Add(statusLabel);
        }

        public void StartGame(object sender, EventArgs e)
        {
            controller.Start();
        }

        void CreateBoardPanel(Board board)
        {
            boardPanel = new BoardPanel(BOARD_SIZE, board.Positions().Count, controller);
            boardPanel.Location = BOARD_LOCATION;
            Controls.Add(boardPanel);
        }

        public Label StatusLabel
        { get { return statusLabel; } }

        //TODO can be replaced by game runner
        public void SetController(GameController controller)
        {
            this.controller = controller;
        }

        public virtual void PrintBoard(Board board)
        {
            if (boardPanel == null)
            {
                CreateBoardPanel(board);
            }

            boardPanel.UpdateBoard(board);
            boardPanel.Update();
            boardPanel.Refresh();
            Application.DoEvents();
        }

        public virtual void PrintMessage(string message)
        {
            statusLabel.Text = message;
            statusLabel.Update();
            statusLabel.Refresh();
            Application.DoEvents();
        }

        public static class Factory
        {
            public static GameForm Build(Game game)
            {
                var gameForm = new GameForm();
                var gameRunner = new GameRunner(game, new GameFormAdapter(gameForm));
                gameForm.SetController(new GameController(gameRunner));
                return gameForm;
            }
        }
    }
}
