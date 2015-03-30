using System.Collections.Generic;
using TicTacToe;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGUI
{
    public class BoardPanel : Panel
    {
        IList<Cell> cells;

        public BoardPanel(int size, int cellCount, GameController controller)
        {
            cells = new List<Cell>();
            this.Size = new Size(size, size);
            InitiateBoard(size, cellCount, controller);
        }

        void InitiateBoard(int size, int cellCount, GameController controller)
        {
            BuildCells(GetColumnCount(cellCount), CalculateCellSize(size, cellCount), controller);
        }

        public void UpdateBoard(Board board)
        {
            for (int i = 0; i < board.Positions().Count; i++)
            {
                cells[i].Text = MarkToText(board.Positions()[i]);
            }
        }

        string MarkToText(Mark mark)
        {
            return mark == Mark.EMPTY ? "" : mark.ToString();
        }

        void BuildCells(double columnCount, int cellHeight, GameController controller)
        {
            int positionCounter = 0;
            var cellXPosition = 0;
            var cellYPosition = 0;
            for (int row = 0; row < columnCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    var cell = new Cell(controller, positionCounter++);
                    formatCell(cell, cellHeight, cellXPosition, cellYPosition);
                    cellXPosition += cellHeight;
                    cells.Add(cell);
                    Controls.Add(cell);
                }
                cellXPosition = 0;
                cellYPosition += cellHeight;
            }
        }

        void formatCell(Control cell, int cellHeight, int cellXPosition, int cellYPosition)
        {
            cell.Size = new Size(cellHeight, cellHeight);
            cell.Location = new Point(cellXPosition, cellYPosition);

        }
        static double GetColumnCount(int cellCount)
        {
            return Math.Sqrt(cellCount);
        }

        int CalculateCellSize(int size, int cellCount)
        {
            double cellSize = (double)size / GetColumnCount(cellCount);
            return Convert.ToInt32(cellSize);
        }
    }
}
