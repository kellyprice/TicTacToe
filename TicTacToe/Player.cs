namespace TicTacToe
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public List<int> State { get; set; } = new List<int> { 0 };
    }
}
