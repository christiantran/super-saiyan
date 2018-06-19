using System.Collections.Generic;

namespace SuperSaiyan.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        public List<Room> Rooms = new List<Room>();
        public bool Playing;








        
    }
}