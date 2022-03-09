namespace TicTacToe
{
    public static class Turn
    {
        public static void AddMove(string position, Player activePlayer)
        {
            activePlayer.State.Add(int.Parse(position));
        }

        public static bool CheckForValidMove(string position, IEnumerable<int> state)
        {
            return !state.Contains(int.Parse(position));
        }

        public static bool CheckForValidInput(string? input)
        {
            _ = int.TryParse(input, out int i);

            return i > 0 && i < 10;
        }
    }
}
