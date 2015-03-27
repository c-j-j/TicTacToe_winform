using NUnit.Framework;

namespace TicTacToeGUI
{
    [TestFixture]
    public class ClickControllerTest
    {
        ClickController clickController;

        [SetUp]
        public void Setup()
        {
            clickController = new ClickController();
        }
        [Test]
        public void HasNoClickEventsStored()
        {
            Assert.AreEqual(false, new ClickController().HasClick());
        }

        [Test]
        public void HasClickEventsStored()
        {
            clickController.AddClickEvent(0);
            Assert.AreEqual(true, clickController.HasClick());
        }

        [Test]
        public void ClickedPositionIsRetrieved()
        {
            clickController.AddClickEvent(3);
            Assert.AreEqual(3, clickController.RetrieveClickedPosition());
        }

        [Test]
        public void ClickedPositionIsResetted()
        {
            clickController.AddClickEvent(3);
            Assert.AreEqual(true, clickController.HasClick());
            clickController.Reset();
            Assert.AreEqual(false, clickController.HasClick());
        }
    }
}
