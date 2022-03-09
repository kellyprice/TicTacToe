namespace TicTacToe
{
    public static class TiedGame
    {
        public static bool Check(IEnumerable<int> state)
        {
            var fullGrid = Enumerable.Range(1, 9).ToList();

            return fullGrid.Intersect(state).Count() == 9;
        }
    }
}
