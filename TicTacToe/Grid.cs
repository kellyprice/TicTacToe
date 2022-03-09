using System.Text;

namespace TicTacToe
{
    public static class Grid
    {
        public static string Get(Player playerOne, Player playerTwo)
        {
            var s = new StringBuilder();

            //loop thru all 9 positions in square
            for (var i = 1; i < 10; i++)
            {
                //if position is in players state, then add
                if (playerOne.State.Contains(i))
                    s.Append(playerOne.Symbol + " ");
                else if (playerTwo.State.Contains(i))
                    s.Append(playerTwo.Symbol + " ");
                else
                    s.Append("- ");

                //new line for 3x3 square
                if (i % 3 == 0)
                    s.Append("\r\n");
            }

            return s.ToString();
        }
    }
}
