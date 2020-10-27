using System;
using System.Collections.Generic;
using System.Text;

namespace DIPractise4
{
    public class PlayerDAL : IPlayerList
    {
        public List<Player> ShowPlayers()
        {
            List<Player> allPlayers = new List<Player>();
            allPlayers.Add(new Player { Id = 5, Description = "Very good defender" });
            allPlayers.Add(new Player { Id = 6, Description = "Very good attacker" });

            return allPlayers;
        }
    }
}
