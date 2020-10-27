using System;
using System.Collections.Generic;
using System.Text;

namespace DIPractise4
{
    public class PlayerBL
    {
        IPlayerList player1;
        public PlayerBL(IPlayerList player1)
        {
            this.player1 = player1;
        }

        public List<Player> GetPlayers()
        {
            List<Player> myPlayers = new List<Player>();
            return player1.ShowPlayers();
        }
    }
}
