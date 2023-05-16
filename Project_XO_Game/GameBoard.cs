using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XO_Game
{
    public class GameBoard
    {
       
       public string[] moves = new string[9];
       public void PrintBoard()
       {
           Console.Write("                   ");
           for (int i = 0; i < moves.Length; i++)
           {
               moves[i] = (i + 1).ToString();
               Console.Write("|" + moves[i] + "|");
               if (i == 2 || i == 5)
               {
                   Console.WriteLine();
                   Console.Write("                   ");
               }
           }
           Console.WriteLine(); 
       }
        // פונקציה לגלגול קוביות
       public int RollDice()
       {          
           Random r = new Random();
           int num1 = r.Next(1, 6);          
           int num2 = r.Next(1, 6);
           int result = num1 + num2;
          
           Console.WriteLine(num1+" "+num2+"  ="+ result);
           return result;
       }
        ////////////

        //// פונקציה להתחלת המשחק ובחירת משבצת
        public void GameMove(bool b,string name)
        {
            Console.WriteLine("{0} please type the number in the table where you want to input your move",name);
            string str;
            if (b)
	        {
               // b = true;
		         str= "O";
        	}
            else
	        {
              //  b = false;
                str="X";
        	}
            Console.Write("                   ");
            for (int i = 0; i < moves.Length; i++)
            {
                moves[i] = (i + 1).ToString();
                Console.Write("|" + moves[i] + "|");
                if (i == 2 || i == 5)
                {
                    Console.WriteLine();
                    Console.Write("                   ");
                }
            }
          
          
            for (int s = 0; s < 9; s++)
            {
                b = !b;
                if (b==true)
                {
                    str = "X";
                }
                else
                {
                    str="O";
                }
                Console.WriteLine();
                Console.WriteLine("Please type the number of place to input");
                int num = 0;
                string num1 = Console.ReadLine();
                bool success= (int.TryParse(num1, out num));
                while (!success)
                {
                    Console.WriteLine("input is not an integer");
                     num = 0;
                     num1 = Console.ReadLine();
                     if (int.TryParse(num1, out num))
                     {
                         success = true;
                     }

                }
                while (success)
                {
                    num = int.Parse(num1);
                    while (num < 1 || num > 9)
                    {
                        Console.WriteLine("num is out of range");                        
                        if (int.TryParse(num1, out num))
                        {
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("input is not an integer");
                          
                        }
                        num1 = Console.ReadLine();
                        int.TryParse(num1, out num);
                        if (num >= 1 || num <= 9)
                        {
                            success = true;
                           
                        }
                    }
                    while (moves[num - 1].Contains("O") || moves[num - 1].Contains("X"))
                    {


                        num = -1;
                        Console.WriteLine("This number of place was already chosen, please choose a different one");
                        num = int.Parse(Console.ReadLine());
                    }
                    if (success)
                    {
                        break;
                    }
                }
                
               
               
                for (int i = 0; i < moves.Length; i++)
                {
                    
                    if (i == num)
                    {
                        moves[i-1] = str;

                    }
                    if (num==9)
                    {
                        moves[8] = str;
                    }
                }
                // בדיקת זכייה

                if (str == "X")
                {

                    if (moves[0] == "X" && moves[3] == "X" && moves[6] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[0] == "X" && moves[1] == "X" && moves[2] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[0] == "X" && moves[4] == "X" && moves[8] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[2] == "X" && moves[5] == "X" && moves[8] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[1] == "X" && moves[4] == "X" && moves[7] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[3] == "X" && moves[4] == "X" && moves[5] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[6] == "X" && moves[7] == "X" && moves[8] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        return;
                    }
                    if (moves[2] == "X" && moves[4] == "X" && moves[6] == "X")
                    {
                        Console.WriteLine("We wave a winner the X-Player won the game");
                        
                        return;
                    }
                }
                //////////////////////////////////////////////////////////////// 
                if (str == "O")
                {

                    if (moves[0] == "O" && moves[3] == "O" && moves[6] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[0] == "O" && moves[1] == "O" && moves[2] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[0] == "O" && moves[4] == "O" && moves[8] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[2] == "O" && moves[5] == "O" && moves[8] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[1] == "O" && moves[4] == "O" && moves[7] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[3] == "O" && moves[4] == "O" && moves[5] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[6] == "O" && moves[7] == "O" && moves[8] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        return;
                    }
                    if (moves[2] == "O" && moves[4] == "O" && moves[6] == "O")
                    {
                        Console.WriteLine("We wave a winner the O-Player won the game");
                        
                        return;
                    }
                }

                //
                Console.Write("                   ");
                for (int i = 0; i < moves.Length; i++)
                {                   
                    Console.Write("|" + moves[i] + "|");
                    if (i == 2 || i == 5)
                    {
                        Console.WriteLine();
                        Console.Write("                   ");
                    }
                }
                Console.WriteLine();
                // כאן עושים את הבדיקה אם מישהו ניצח
            }
            
        }
       
    }

}
