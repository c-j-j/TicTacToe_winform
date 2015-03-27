using Moq;
using NUnit.Framework;

namespace TicTacToeGUI.Tests
{
    [TestFixture]
    public class GameControllerTest
    {

        GameController gameController;
        Mock<GameRunnerWrapper> gameRunnerAdapter;
        Mock<ClickController> clickController;

        [SetUp]
        public void Setup(){
            gameRunnerAdapter = new Mock<GameRunnerWrapper>();
            gameRunnerAdapter.Setup(m => m.Run());
            clickController = new Mock<ClickController>();
            clickController.Setup(m => m.AddClickEvent(3));
            gameController = new GameController(gameRunnerAdapter.Object, clickController.Object);
        }

        [Test]
        public void CellClickRunsGameRunner()
        {
            gameController.CellClicked(3);
            gameRunnerAdapter.Verify(m => m.Run());
        }

        [Test]
        public void AddsClickedCellToClickController()
        {
            gameController.CellClicked(3);
            clickController.Verify(m => m.AddClickEvent(3));
        }

        [Test]
        public void StartInvokesGameRunner()
        {
            gameController.Start();
            gameRunnerAdapter.Verify(m => m.Run());
        }
    }
}
