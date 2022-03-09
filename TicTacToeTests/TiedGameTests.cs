using NUnit.Framework;
using System.Linq;
using TicTacToe;

namespace TicTacToeTests
{
    public class TiedGameTests
    {
        [Test]
        public void TheGameIsTied()
        {
            //arrange
            var playerOne = new Player() { Name = "Player One", Symbol = "X" };
            var playerTwo = new Player() { Name = "Player Two", Symbol = "0" };

            //act
            playerOne.State.Add(1);
            playerTwo.State.Add(2);
            playerTwo.State.Add(3);
            playerTwo.State.Add(4);
            playerOne.State.Add(5);
            playerOne.State.Add(6);
            playerOne.State.Add(7);
            playerOne.State.Add(8);
            playerTwo.State.Add(9);

            var state = playerOne.State.Union(playerTwo.State).ToList();

            var isTiedGame = TiedGame.Check(state);

            //assert
            Assert.IsTrue(isTiedGame);
        }

        [Test]
        public void TheGameIsNotTied()
        {
            //arrange
            var playerOne = new Player() { Name = "Player One", Symbol = "X" };
            var playerTwo = new Player() { Name = "Player Two", Symbol = "0" };

            //act
            playerOne.State.Add(1);
            playerTwo.State.Add(2);
            playerTwo.State.Add(3);
            playerTwo.State.Add(4);
            playerOne.State.Add(5);
            playerOne.State.Add(6);
            playerOne.State.Add(7);
            playerOne.State.Add(8);

            var state = playerOne.State.Union(playerTwo.State).ToList();

            var isTiedGame = TiedGame.Check(state);

            //assert
            Assert.IsFalse(isTiedGame);
        }
    }
}