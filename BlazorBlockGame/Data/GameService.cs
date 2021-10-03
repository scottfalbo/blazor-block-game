using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Data
{
    public class GameService
    {
        public GameCell[,] CreateBoard(int x, int y)
        {
            GameCell[,] newGame = new GameCell[x, y];
            int counter = 1;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    newGame[i, j] = new GameCell()
                    {
                        Id = counter,
                        ImageUrl = $"someurl{counter}"
                    };
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
