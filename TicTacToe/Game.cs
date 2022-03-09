namespace TicTacToe
{
    internal class Game
    {
        private Player _playerOne = new Player() { Name = "Player One", Symbol = "X" };
        private Player _playerTwo = new Player() { Name = "Player Two", Symbol = "O" };
        private Player _activePlayer;
        private bool _gameWon = false;
        private bool _tiedGame = false;

        public Game()
        {
            _activePlayer = _playerOne;
        }

        public void Play()
        {
            Console.WriteLine(Instructions.Get());

            while (!_gameWon && !_tiedGame)
            {
                var state = _playerOne.State.Union(_playerTwo.State);

                if (_playerOne.State.Count() > 1)
                    Console.WriteLine($"\r\n{Grid.Get(_playerOne, _playerTwo)}");

                Console.WriteLine($"It's your turn, {_activePlayer.Name}! Enter your move.");

                var position = Console.ReadLine();

                if (!Turn.CheckForValidInput(position))
                {
                    Console.WriteLine("\r\nYou must enter a number between 1 and 9!");

                    continue;
                }

                if (!Turn.CheckForValidMove(position, state))
                {
                    Console.WriteLine("\r\nThere is already a move in that position!");

                    continue;
                }

                Turn.AddMove(position, _activePlayer);

                state = _playerOne.State.Union(_playerTwo.State);

                _gameWon = HasWon.Check(_activePlayer);
                _tiedGame = TiedGame.Check(state);

                if (!_gameWon)
                    _activePlayer = _activePlayer == _playerOne ? _playerTwo : _playerOne;
            }

            Console.WriteLine($"\r\n{Grid.Get(_playerOne, _playerTwo)}");

            if (_tiedGame && !_gameWon)
                Console.WriteLine("The game has been tied!");
            else
                Console.WriteLine($"You have won, {_activePlayer.Name}!");
        }
    }
}
