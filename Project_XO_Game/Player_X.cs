using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XO_Game
{
    public class Player_X
    {
        private string playerName;
        public int BeginAndTurn;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        
        private string moveX;

        public string MoveX
        {
            get { return moveX; }
            set { moveX = value; }
        }
        
    }
}
