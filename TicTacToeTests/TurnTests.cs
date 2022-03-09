using NUnit.Framework;
using TicTacToe;
using System.Collections.Generic;

namespace TicTacToeTests
{
    public class TurnTests
    {
        [Test]
        public void AddMoveForPlayer()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);
            activePlayer.State.Add(2);

            Turn.AddMove("3", activePlayer);

            var expectedState = new List<int>() { 0, 1, 2, 3 };

            var actualState = activePlayer.State;

            //assert
            Assert.AreEqual(expectedState, actualState);
        }

        [Test]
        public void CheckForValidMove()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);

            var isValid = Turn.CheckForValidMove("2", activePlayer.State);

            //assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void CheckForInvalidMove()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);

            var isValid = Turn.CheckForValidMove("1", activePlayer.State);

            //assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void CheckForValidInput()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);

            var isValid = Turn.CheckForValidInput("1");

            //assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void CheckForInvalidNumericInput()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);

            var isValid = Turn.CheckForValidInput("10");

            //assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void CheckForInvalidCharInput()
        {
            //arrange
            var activePlayer = new Player() { Name = "Player One", Symbol = "X" };

            //act
            activePlayer.State.Add(1);

            var isValid = Turn.CheckForValidInput("z");

            //assert
            Assert.IsFalse(isValid);
        }
    }
}