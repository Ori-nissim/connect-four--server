namespace connect_four__server.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public float Duration { get; set; }
        public int PlayerID { get; set; }


        public Game() { }
    }
}
