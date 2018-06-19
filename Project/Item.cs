using System.Collections.Generic;

namespace SuperSaiyan.Project
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Available { get; set; }
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
            Available = false;
        }
    }
}