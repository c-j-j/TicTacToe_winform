using TicTacToe;
using NUnit.Framework;

namespace TicTacToeGUI
{
    [TestFixture]
    public class GUIPlayerTest
    {
        GUIPlayer player;

        [SetUp]
        public void Setup()
        {
            player = new GUIPlayer(Mark.X);
        }

        [Test]
        public void IsNotReadyToPlayInitially()
        {
            Assert.AreEqual(false, player.Ready());
        }

        [Test]
        public void IsReadyToPlayWhenPositionSet()
        {
            player.SetNextPosition(3);
            Assert.AreEqual(true, player.Ready());
        }

        [Test]
        public void MarkIsTheSameThatIsPassedIn()
        {
            Assert.AreEqual(Mark.X, player.Mark);
        }

        [Test]
        public void NextPositionIsResetWhenGetMoveIsCalled()
        {
            player.SetNextPosition(3);
            Assert.AreEqual(3, player.GetMove(null).Position);
            Assert.AreEqual(GUIPlayer.WAITING, player.NextPosition);
        }

        [Test]
        public void FactoryBuildsGUIPlayer()
        {
            var newPlayer = new GUIPlayer.Factory().Build(Mark.X, Mark.O);
            Assert.AreEqual(newPlayer.Mark, Mark.X);
        }

    }
}
