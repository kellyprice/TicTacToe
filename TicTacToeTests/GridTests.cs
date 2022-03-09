using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTests
{
    public class BoardTests
    {
        [Test]
        public void BoardIsInRightState()
        {
            //arrange
            var playerOne = new Player() { Name = "Player One", Symbol = "X" };
            var playerTwo = new Player() { Name = "Player Two", Symbol = "O" };

            //act
            playerOne.State.Add(1);
            playerOne.State.Add(4);
            playerTwo.State.Add(3);

            var expectedState = "X - O \r\n";
            expectedState += "X - - \r\n";
            expectedState += "- - - \r\n";

            var actualState = Grid.Get(playerOne, playerTwo);

            //assert
            Assert.AreEqual(expectedState, actualState);
        }
    }
}