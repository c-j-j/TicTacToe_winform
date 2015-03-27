using TicTacToe;
using NUnit.Framework;

namespace TicTacToeGUI
{
    [TestFixture]
    public class GUIPlayerTest
    {
        GUIPlayer player;
        ClickController clickController;

        [SetUp]
        public void Setup(){
            clickController = new ClickController();
            player = new GUIPlayer(Mark.X, clickController);
        }

        [Test]
        public void IsNotReadyToPlayWhenClickControllerHasNoClicks()
        {
            Assert.AreEqual(false, player.Ready());
        }

        [Test]
        public void IsReadyToPlayWhenClickControllerHasClicks()
        {
            clickController.AddClickEvent(0);
            Assert.AreEqual(true, player.Ready());
        }

        [Test]
        public void MoveRetrievedFromClickController()
        {
            clickController.AddClickEvent(0);
            Assert.AreEqual(0, player.GetMove(null).Position);
        }

        [Test]
        public void PlayerResetsClickControllerOncePositionExtractedFromIt()
        {
            clickController.AddClickEvent(0);
            player.GetMove(null);
            Assert.AreEqual(false, clickController.HasClick());
        }

        [Test]
        public void MarkIsTheSameThatIsPassedIn()
        {
            Assert.AreEqual(Mark.X, player.Mark);
        }

    }
}
