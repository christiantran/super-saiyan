using System.Collections.Generic;

namespace SuperSaiyan.Project
{
    public interface IPlayer
    {
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}