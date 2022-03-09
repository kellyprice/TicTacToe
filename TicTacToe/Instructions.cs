using System.Text;

namespace TicTacToe
{
    internal static class Instructions
    {
        public static string Get()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Player 1 is X\r\n");
            s.Append("Player 2 is O\r\n");
            s.Append("\r\nWhen entering your move, select a number corresponding to the grid below...\r\n");
            s.Append("\r\n1 2 3");
            s.Append("\r\n4 5 6");
            s.Append("\r\n7 8 9\r\n");

            return s.ToString();
        }
    }
}
