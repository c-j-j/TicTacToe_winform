using NUnit.Framework;
using Moq;

namespace TicTacToeGUI
{
    [TestFixture]
    public class CellTest
    {
        [Test]
        public void InvokesControllerWithPosition()
        {
            var mockGameController = new Mock<Controller>();
            mockGameController.Setup(gc => gc.CellClicked(5));
            var cell = new Cell(mockGameController.Object, 5);
            cell.PerformClick();
            mockGameController.Verify(gc => gc.CellClicked(5));
        }
    }
}
