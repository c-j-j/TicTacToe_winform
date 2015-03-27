using TicTacToe;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGUI
{
    public class GameForm : Form
    {
        Controller controller;
        BoardPanel boardPanel;
        Label statusLabel;

        public GameForm()
        {
            SetupStatusLabel();
            SetupStartButton();
            CenterToScreen();
        }

        public Label StatusLabel
        {
            get
            {
                return statusLabel;
            }
        }

        public void SetController(Controller controller)
        {
            this.controller = controller;
        }

        void SetupStartButton()
        {
            var startButton = new Button();
            startButton.Location = new Point(10, 5);
            startButton.Text = "Play Game";
            startButton.Click += CreateGame;
            this.Controls.Add(startButton);
        }

        void SetupStatusLabel()
        {
            statusLabel = new Label();
            statusLabel.Text = "Status label";
            statusLabel.Location = new Point(100, 5);
            this.Controls.Add(statusLabel);
        }

        void CreateGame(object sender, EventArgs e)
        {
            boardPanel = new BoardPanel(200, 9, controller);
            boardPanel.Location = new Point(10, 50);
            this.Controls.Add(boardPanel);
            controller.Start();
        }

        public virtual void PrintBoard(Board board)
        {
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
    }
}
