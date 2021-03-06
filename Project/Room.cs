using System.Collections.Generic;

namespace SuperSaiyan.Project
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();

        public Room Go(string direction)
        {
            if (Exits.ContainsKey(direction))
            {
                return Exits[direction];
            }
            return null;
        }

        public void UseItem(Item item)
        {

        }

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
        }
    }
}