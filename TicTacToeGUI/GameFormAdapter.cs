using System;
using System.Windows.Forms;
using System.Drawing;
using TicTacToe;

namespace TicTacToeGUI
{
    public class GameFormAdapter : Display
    {
        GameForm formPart;

        public GameFormAdapter(GameForm formPart)
        {
            this.formPart = formPart;
        }

        public override void PrintMessage(string message)
        {
            formPart.PrintMessage(message);
        }

        public override void PrintBoard(TicTacToe.Board board)
        {
            Console.WriteLine("printed board");
        }
    }
}
