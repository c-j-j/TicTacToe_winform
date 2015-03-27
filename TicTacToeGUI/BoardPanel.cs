using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGUI
{
    public class BoardPanel : Panel
    {
        public BoardPanel(int size, int cellCount)
        {
            this.Size = new Size(size, size);
            InitiateBoard(size, cellCount);
        }


        void InitiateBoard(int size, int cellCount)
        {
            BuildCells(GetColumnCount(cellCount), CalculateCellSize(size, cellCount));

        }

        void BuildCells(double columnCount, int cellHeight)
        {
            int positionCounter = 0;
            var cellXPosition = 0;
            var cellYPosition = 0;
            for (int row = 0; row < columnCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    var cell = new Cell(positionCounter++);
                    formatCell(cell, cellHeight, cellXPosition, cellYPosition);
                    cellXPosition += cellHeight;
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
