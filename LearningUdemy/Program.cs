using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace LearningUdemy
{
    public class Program
    {
        static int   Main(string[] args)
        {
            try
            {
                string  Player2;
                string Player1;
                int chance=0;
                char[,] mat = new char[3, 3]
                {
                {'1','2','3'},  //Row 0
                {'4','5','6'},  //Row 1
                {'7','8','9'}   //Row 2
                };


                Player1 = GetPlayerString();
                if (Player1 == "E")
                { throw new System.ArgumentException(); }
                else
                {
                    Console.WriteLine("player1 =", Player1);
                    if (Player1 == "O") Player2 = "X";
                    else Player2 = "O";
                    Console.WriteLine("\n Player1 character will be :{0} ", Player1);
                    Console.WriteLine("\n Player2 character will be :{0} ", Player2);


                    setfield(mat);
                    while(ReturnWinner(Player1, Player2, mat) !=1 || ReturnWinner(Player1, Player2, mat) != 2 || ReturnWinner(Player1, Player2, mat) != 3)
                    {

                        if (chance % 2 == 0) Console.WriteLine("\nPlayer 1 choose field no");
                        else Console.WriteLine("\nPlayer 2 choose field no :");
                        var input = Console.ReadLine();
                        if(assignValue(input, mat))
                        {                            
                            setfield(mat);
                            chance++;
                        }
                        
                    }




                }

            }
            catch (Exception )
            {
                Console.WriteLine("\nClosing Game");
                
            }


            int ReturnWinner( string P1 , string P2 , char[,]mat)
            {
                int result = 0;
                
                List<char> assigned = new List<char> { 'X', 'O' };
                foreach( var assign in assigned)
                {

                    if (mat[0, 0] == assign && mat[0, 1] == assign && mat[0, 2] == assign ||
                        mat[1, 0] == assign && mat[1, 1] == assign && mat[1, 2] == assign ||
                        mat[2, 0] == assign && mat[2, 1] == assign && mat[2, 2] == assign ||
                        mat[0, 0] == assign && mat[1, 0] == assign && mat[2, 0] == assign ||
                        mat[0, 1] == assign && mat[1, 1] == assign && mat[2, 1] == assign ||
                        mat[0, 2] == assign && mat[1, 2] == assign && mat[2, 2] == assign ||
                        mat[0, 0] == assign && mat[1, 1] == assign && mat[2, 2] == assign ||
                        mat[2, 0] == assign && mat[1, 1] == assign && mat[0, 2] == assign
                        )
                    {
                        if (assign == char.Parse(P1)) result = 1;
                        else if (assign == char.Parse(P2)) result = 2;
                        else result = 3;
                    }

                    else result = 4;
                }

                return result;
            }

            void setfield(char[,] mat)
            {
                Console.Clear();
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", mat[0, 0], mat[0, 1], mat[0, 2]);
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", mat[1, 0], mat[1, 1], mat[1, 2]);
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", mat[2, 0], mat[2, 1], mat[2, 2]);
                Console.WriteLine("     |     |     ");
            }
          
            bool checkCorretFieldValue(string filed, char[,] mat)
            {
                bool correctinput = true;

                if ((filed == "1") && (mat[0, 1] == '1')) correctinput = true;
                else if ((filed == "2") && (mat[0, 1] == '2')) correctinput = true;
                else if ((filed == "3") && (mat[0, 2] == '3')) correctinput = true;
                else if ((filed == "4") && (mat[1, 0] == '4')) correctinput = true;
                else if ((filed == "5") && (mat[1, 1] == '5')) correctinput = true;
                else if ((filed == "6") && (mat[1, 2] == '6')) correctinput = true;
                else if ((filed == "7") && (mat[2, 0] == '7')) correctinput = true;
                else if ((filed == "8") && (mat[2, 1] == '8')) correctinput = true;
                else if ((filed == "9") && (mat[2, 2] == '9')) correctinput = true;
                else correctinput = false;

                return correctinput;
            }
            
            bool checkAlreadyfield(string fieldValue, char[,] mat)
            {
                bool correctinput = true;
                List<string> Value = new List<string> { "X", "O" };
                if (checkCorretFieldValue(fieldValue,mat)) correctinput = true;
                else correctinput = false;
                return correctinput;
            }
            bool assignValue(string Value,char[,] mat)
            {
                bool assigned = true;
                if (checkAlreadyfield(Value, mat))
                {
                    switch (Value)
                    {
                        case "1": mat[0, 0] = char.Parse(Value); break;
                        case "2": mat[0, 1] = char.Parse(Value); break;
                        case "3": mat[0, 2] = char.Parse(Value); break;
                        case "4": mat[1, 0] = char.Parse(Value); break;
                        case "5": mat[1, 1] = char.Parse(Value); break;
                        case "6": mat[1, 2] = char.Parse(Value); break;
                        case "7": mat[2, 0] = char.Parse(Value); break;
                        case "8": mat[2, 1] = char.Parse(Value); break;
                        case "9": mat[2, 2] = char.Parse(Value); break;

                    }

                }
                else
                {
                    assigned = false;
                    Console.WriteLine("\n Either space already have value or Incorrect field value supplied");
                }
                return assigned;
            }

            string GetPlayerString( )
            {
                List<string> Action = new List<string> { "E", "X", "O" };
                Console.WriteLine("\nPlayer 1 chose your value : O/X OR if you don't want to play enter E");
                var Player1 = Console.ReadLine().ToUpper();

                if (Action.Contains(Player1))
                { return Player1; }
                else { GetPlayerString(); }
                
                return Player1;
            }
            return 0;
        }

        
    }
}
