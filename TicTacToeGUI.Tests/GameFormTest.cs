using Moq;
using NUnit.Framework;
namespace TicTacToeGUI
{
    [TestFixture]
    public class GameFormTest
    {
        [Test]
        public void StartGameInvokesGameController()
        {
            var mockGameController = new Mock<GameController>();
            mockGameController.Setup(gc => gc.Start());
            var gameForm = new GameForm();
            gameForm.SetController(mockGameController.Object);
            gameForm.StartGame(null, null);
            mockGameController.Verify(m => m.Start());
        }

    }
}
