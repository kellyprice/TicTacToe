using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTests
{
    public class HasWonTests
    {
        [Test]
        public void CheckHorizontalWinningPosition()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);
            activePlayer.State.Add(2);
            activePlayer.State.Add(3);

            var hasWon = HasWon.Check(activePlayer);

            //assert
            Assert.IsTrue(hasWon);
        }

        [Test]
        public void CheckVerticalWinningPosition()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);
            activePlayer.State.Add(4);
            activePlayer.State.Add(7);

            var hasWon = HasWon.Check(activePlayer);

            //assert
            Assert.IsTrue(hasWon);
        }

        [Test]
        public void CheckDiagonalWinningPosition()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);
            activePlayer.State.Add(5);
            activePlayer.State.Add(9);

            var hasWon = HasWon.Check(activePlayer);

            //assert
            Assert.IsTrue(hasWon);
        }

        [Test]
        public void CheckLosingPosition()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);
            activePlayer.State.Add(4);
            activePlayer.State.Add(8);

            var hasWon = HasWon.Check(activePlayer);

            //assert
            Assert.IsFalse(hasWon);
        }
    }
}