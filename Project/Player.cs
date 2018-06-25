using System;
using System.Collections.Generic;


namespace SuperSaiyan.Project
{
    public class Player : IPlayer
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public List<Item> Inventory { get; set; }

         public Player(string name)
        {
            Name = name;
            Inventory = new List<Item>();
        }
    }
}