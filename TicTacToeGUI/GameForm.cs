using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGUI
{
    public class GameForm : Form
    {
        GameController controller;

        public void SetController(GameController controller)
        {
            this.controller = controller;
        }

        public void Start()
        {
            controller.Start();
        }

        Label label;
        public GameForm()
        {
            var boardPanel = new BoardPanel(100, 9);
            this.Controls.Add(boardPanel);
            //boardPanel.Location = new Point(10, 10);
            //this.Controls.Add(boardPanel);
            //Text = "Simple";
            //Size = new Size(250, 200);
            //button = new Button();
            //button.Text = "A Button";
            //button.Parent = this;
            //button.Location = new Point(10, 30);
            //button.Size = new Size(60, 60);
            //button.Click += clickHandler;
            //label = new Label();
            //label.Text = "Hello World";
            //label.Location = new Point(50, 30);
            //label.Parent = this;
            //Console.WriteLine(this);

            CenterToScreen();
        }

        public void PrintMessage(string message)
        {
            label.Text = message;
            label.Update();
            label.Refresh();
            Application.DoEvents();
        }

        Button button;

        void clickHandler(object sender, EventArgs e)
        {
            Start();
            Console.WriteLine("hello world");
        }
    }
}
