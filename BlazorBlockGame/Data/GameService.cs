using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Data
{
    public class GameService
    {
        public int[,] CreateBoard(int x, int y)
        {
            int[,] newGame = new int[x, y];
            int counter = 1;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    newGame[i, j] = counter;
                    counter++;
                }
            }
            return newGame;
        }

        // make move

        // check move

        // check winner
        
    }
}
