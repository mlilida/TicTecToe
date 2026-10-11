using System;
using System.Collections.Generic;
using System.Text;

namespace TicTecToe
{
    internal class Board
    {
        private int[] location = new int[9];
        private string[] GameBoard = new string[9];

        public Board()
        {
            int num = 1;
            for (int i = 0; i < 9; i++)
            {
                location[i] = num++;
            }
            
            for (int i = 0; i < 9; i++)
            {
                GameBoard[i] = ".";
            }
        }

        public void ShowLocation()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{location[i * 3]} | {location[i * 3 + 1]} | {location[i * 3 + 2]}");

                if (i < 2)
                {
                    Console.WriteLine("---------");
                }
            }
        }


        public void ShowGameBoard(string[] input)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{input[i * 3]} | {input[i * 3 + 1]} | {input[i * 3 + 2]}");

                if (i < 2)
                {
                    Console.WriteLine("---------");
                }
            }
        }

        public bool Winner(string[] input)
        {
            if (input[0] != "." && input[0] == input[1] && input[1] == input[2]) return true;
            if (input[3] != "." && input[3] == input[4] && input[4] == input[5]) return true;
            if (input[6] != "." && input[6] == input[7] && input[7] == input[8]) return true;

            if (input[0] != "." && input[0] == input[3] && input[3] == input[6]) return true;
            if (input[1] != "." && input[1] == input[4] && input[4] == input[7]) return true;
            if (input[2] != "." && input[2] == input[5] && input[5] == input[8]) return true;

            if (input[0] != "." && input[0] == input[4] && input[4] == input[8]) return true;
            if (input[2] != "." && input[2] == input[4] && input[4] == input[6]) return true;

            return false;
        }
    }
}
