using NUnit.Framework;
using Moq;
using TicTacToe;

namespace TicTacToeGUI
{
    [TestFixture]
    public class GameFormAdapterTest
    {
       [Test]
       public void DelegatesPrintMessageToForm()
       {
           var board = new Board();
           var gameForm = new Mock<GameForm>();
           gameForm.Setup(g=>g.PrintBoard(board));
           var gameFormAdapter = new GameFormAdapter(gameForm.Object);
           gameFormAdapter.PrintBoard(board);
       }
    }
}
