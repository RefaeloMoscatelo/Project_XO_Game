using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Project_XO_Game
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("          ********************************");
            Console.WriteLine("          **** Welcome to the XO Gmae ****");
            Console.WriteLine("          ********************************");
            Player_X XPlayer = new Player_X();
            Player_O OPlayer = new Player_O();
            Console.WriteLine("Please enter the Name of the X Player");
            XPlayer.PlayerName = Console.ReadLine();
            while (XPlayer.PlayerName ==string.Empty)
            {
                Console.WriteLine("You haven't entered a name, please type one");
                XPlayer.PlayerName = Console.ReadLine();
            }
            Console.WriteLine("Please enter the Name of O Player");
            OPlayer.PlayerName = Console.ReadLine();
            while (OPlayer.PlayerName == string.Empty)
            {
                Console.WriteLine("You haven't entered a name, please type one");
                OPlayer.PlayerName = Console.ReadLine();
            }
            while (XPlayer.PlayerName == OPlayer.PlayerName)
            {
                Console.WriteLine("Two Names are Identical, O Player please retype another name/ add letters/ write differently");
                OPlayer.PlayerName = Console.ReadLine();
            }
            Thread.Sleep(500);
            Console.WriteLine("Let the Game begin");

            GameBoard Board = new GameBoard();
            Board.PrintBoard();

            Console.WriteLine("Please Roll Dice, first {0} to roll dice, click any key to start", XPlayer.PlayerName);
            string str1 = Console.ReadLine();
            XPlayer.BeginAndTurn = Board.RollDice();
            Console.WriteLine("Now {0} Roll Dice", OPlayer.PlayerName);
            string str2 = Console.ReadLine();
            OPlayer.BeginAndTurn = Board.RollDice();

            while (OPlayer.BeginAndTurn == XPlayer.BeginAndTurn)
            {
                Console.WriteLine("The Dice results are equal, please rethrow Dice");
                Console.WriteLine("Please Roll Dice, first Player X to roll dice");
                XPlayer.BeginAndTurn = Board.RollDice();
                Console.WriteLine("Now Player O Roll Dice");
                OPlayer.BeginAndTurn = Board.RollDice();
            }
            bool b;
            if (  OPlayer.BeginAndTurn> XPlayer.BeginAndTurn)
            {
                Console.WriteLine("{0} is starting", OPlayer.PlayerName);
                b = true;
                Board.GameMove(b, OPlayer.PlayerName);
            }
            else
            {
                Console.WriteLine("{0} is starting", XPlayer.PlayerName);
                b = false;
                Board.GameMove(b, XPlayer.PlayerName);
            }
          
            
            
        }
    }
}
