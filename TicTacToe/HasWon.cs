namespace TicTacToe
{
    public static class HasWon
    {
        private static readonly int[][] winningLines = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9},
            new int[] {1, 4, 7},
            new int[] {2, 5, 8},
            new int[] {3, 6, 7},
            new int[] {1, 5, 9},
            new int[] {3, 5, 7}
        };

        public static bool Check(Player player)
        {
            var state = player.State.ToArray();

            // loop through all possible winning lines and check against player state 
            for (var i = 0; i < 8; i++)
            {
                if (state.Intersect(winningLines[i]).ToArray().Length == 3)
                    return true;
            }

            return false;
        }
    }
}
