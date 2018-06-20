using System.Collections.Generic;

namespace SuperSaiyan.Project
{
    public interface IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Setup();
        void Reset();

        //no need to pass a room since Items can only be used in the CurrentRoom
        void UseItem(string itemName);
    }
}