﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Multiplayer
    {
        public static void TTTMultiplayer(string[] placeHolders)
        {
            bool win = false;
            bool xOrO = false;
            int turns = 0;
            int userChoice = 0;
            string playerOne = null;
            string playerTwo = null;
            string winner = null;

            do
            {

                while (xOrO == false)
                {
                    Console.WriteLine("Player 1 : X or O?");
                    playerOne = Console.ReadLine();
                    playerOne = playerOne.ToUpper();
                    if (playerOne == "X")
                    {
                        Console.WriteLine("Player 1 is Xs!\nPlayer 2 is Os!");
                        playerTwo = "O";
                        xOrO = true;
                        Board.TTTBoard(placeHolders);
                    }
                    else if (playerOne == "O")
                    {
                        Console.WriteLine("Player 1 is Os!\nPlayer 2 is Xs!");
                        playerTwo = "X";
                        xOrO = true;
                        Board.TTTBoard(placeHolders);
                    }
                    else
                        Console.WriteLine("Not an option");
                }

                if (turns % 2 == 0)
                {
                    Console.WriteLine("Player 1's turn : ");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    while (turns % 2 == 0)
                    {
                        if (placeHolders[userChoice] == "X" || placeHolders[userChoice] == "O")
                        {
                            Console.WriteLine("Already taken. Choose another.");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (placeHolders[userChoice] == "1" || placeHolders[userChoice] == "2" || placeHolders[userChoice] == "3" ||
                            placeHolders[userChoice] == "4" || placeHolders[userChoice] == "5" || placeHolders[userChoice] == "6" || placeHolders[userChoice] == "7"
                            || placeHolders[userChoice] == "8" || placeHolders[userChoice] == "9")
                        {
                            placeHolders[userChoice] = playerOne;
                            ++turns;
                        }
                        else
                        {
                            Console.WriteLine("That is not an answer. Choose 1 through 9.");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Board.TTTBoard(placeHolders);
                }
                else
                {
                    Console.WriteLine("Player 2's turn : ");
                    
                    while (turns % 2 != 0)
                    {
                        userChoice = Convert.ToInt32(Console.ReadLine());
                        if (placeHolders[userChoice] == "X" || placeHolders[userChoice] == "O")
                        {
                            Console.WriteLine("Already taken. Choose another.");
                        }
                        else if (placeHolders[userChoice] == "1" || placeHolders[userChoice] == "2" || placeHolders[userChoice] == "3" ||
                           placeHolders[userChoice] == "4" || placeHolders[userChoice] == "5" || placeHolders[userChoice] == "6" || placeHolders[userChoice] == "7"
                           || placeHolders[userChoice] == "8" || placeHolders[userChoice] == "9")
                        {
                            placeHolders[userChoice] = playerTwo;
                            ++turns;
                        }
                        else
                        {
                            placeHolders[userChoice] = playerTwo;
                            ++turns;
                        }
                    }
                    Board.TTTBoard(placeHolders);
                }

                if (placeHolders[0] == playerOne && placeHolders[1] == playerOne && placeHolders[2] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[3] == playerOne && placeHolders[4] == playerOne && placeHolders[5] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[6] == playerOne && placeHolders[7] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[0] == playerOne && placeHolders[3] == playerOne && placeHolders[6] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[1] == playerOne && placeHolders[4] == playerOne && placeHolders[7] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[2] == playerOne && placeHolders[5] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[2] == playerOne && placeHolders[4] == playerOne && placeHolders[6] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                else if (placeHolders[0] == playerOne && placeHolders[4] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }

                if (placeHolders[0] == playerOne && placeHolders[1] == playerOne && placeHolders[2] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[3] == playerOne && placeHolders[4] == playerOne && placeHolders[5] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[6] == playerOne && placeHolders[7] == playerOne && placeHolders[8] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[0] == playerOne && placeHolders[3] == playerOne && placeHolders[6] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[1] == playerOne && placeHolders[4] == playerOne && placeHolders[7] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[2] == playerOne && placeHolders[5] == playerOne && placeHolders[8] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[2] == playerOne && placeHolders[4] == playerOne && placeHolders[6] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                else if (placeHolders[0] == playerOne && placeHolders[4] == playerOne && placeHolders[8] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }

            } while (win == false);
            Console.WriteLine("{0} wins!", winner);


            for (int i = 0; i < placeHolders.Length; i++)
            {
                placeHolders[i] = Convert.ToString(i); 
            }
         
        }
    }
}
