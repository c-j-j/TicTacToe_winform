using NUnit.Framework;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    [TestFixture]
    public class BoardPanelTest
    {
        BoardPanel boardPanel;

        [Test]
        public void BuildsBoardPanelWithGivenSize()
        {
            boardPanel = new BoardPanel(90, 3);
            Assert.AreEqual(boardPanel.Size.Height, 90);
            Assert.AreEqual(boardPanel.Size.Width, 90);
        }

        [Test]
        public void BuildsNineCells()
        {
            boardPanel = new BoardPanel(90, 9);
            Assert.AreEqual(boardPanel.Controls.Count, 9);
        }

        [Test]
        public void CalculatesSizeOfCells()
        {
            boardPanel = new BoardPanel(90, 9);
            var cells = boardPanel.Controls.Cast<Control>();
            Assert.AreEqual(cells.First().Size.Height, 30);
            Assert.AreEqual(cells.First().Size.Width, 30);
        }

        [Test]
        public void CalculationsLocationOfCells()
        {
            TestCellLocation(0, 0, 0);
            TestCellLocation(1, 30, 0);
            TestCellLocation(2, 60, 0);
            TestCellLocation(3, 0, 30);
            TestCellLocation(4, 30, 30);
            TestCellLocation(5, 60, 30);
            TestCellLocation(6, 0, 60);
            TestCellLocation(7, 30, 60);
            TestCellLocation(8, 60, 60);
        }

        void TestCellLocation(int position, int X, int Y)
        {
            boardPanel = new BoardPanel(90, 9);
            var cells = boardPanel.Controls.Cast<Control>();
            var topMiddleCell = cells.ElementAt(position);
            Assert.AreEqual(X, topMiddleCell.Location.X);
            Assert.AreEqual(Y, topMiddleCell.Location.Y);
        }

    }
}
