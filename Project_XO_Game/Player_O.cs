using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XO_Game
{
   public  class Player_O
    {
        private string moveO;
        public int BeginAndTurn;

        public string MoveO
        {
            get { return moveO; }
            set { moveO = value; }
        }
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        
    }
}
