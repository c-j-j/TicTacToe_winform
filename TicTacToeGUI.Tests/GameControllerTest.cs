using Moq;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToeGUI.Tests
{
    [TestFixture]
    public class GameControllerTest
    {
        GameController gameController;
        Mock<GameRunner> gameRunnerAdapter;
        GUIPlayer guiPlayer;

        [SetUp]
        public void Setup()
        {
            gameRunnerAdapter = new Mock<GameRunner>();
            gameRunnerAdapter.Setup(m => m.Run());
            guiPlayer = new GUIPlayer(Mark.X);
            gameRunnerAdapter.Setup(m => m.CurrentPlayer()).Returns(guiPlayer);
            gameController = new GameController(gameRunnerAdapter.Object);
        }

        [Test]
        public void ClickedCellTriggersGameRunner()
        {
            gameController.CellClicked(3);
            gameRunnerAdapter.Verify(m => m.Run());
        }

        [Test]
        public void ClickedCellPreparesCurrentGUIPlayer()
        {
            gameController.CellClicked(3);
            Assert.AreEqual(3, guiPlayer.NextPosition);
        }

        [Test]
        public void StartInvokesGameRunner()
        {
            gameController.Start();
            gameRunnerAdapter.Verify(m => m.Run());
        }
    }
}
