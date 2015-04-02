using System.Collections.Generic;
using TicTacToe;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGUI
{
    public class BoardPanel : Panel
    {
        List<Cell> cells;

        public BoardPanel(int size, int cellCount, GameController controller)
        {
            cells = new List<Cell>();
            Size = new Size(size, size);
            InitiateBoard(size, cellCount, controller);
        }

        void InitiateBoard(int size, int cellCount, GameController controller)
        {
            BuildCells(GetColumnCount(cellCount), CalculateCellSize(size, cellCount), controller);
        }

        public void UpdateBoard(Board board)
        {
            //TODO cell has information it could use to update itself via GC
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
                    //TODO cell formation can be used in cell class, not here
                    var cell = new Cell(controller, positionCounter++);
                    FormatCell(cell, cellHeight, cellXPosition, cellYPosition);
                    cellXPosition += cellHeight;
                    cells.Add(cell);
                }
                cellXPosition = 0;
                cellYPosition += cellHeight;
            }

            cells.ForEach(Controls.Add);

        }

        void FormatCell(Control cell, int cellHeight, int cellXPosition, int cellYPosition)
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
