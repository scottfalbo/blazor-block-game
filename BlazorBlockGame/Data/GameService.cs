using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Data
{
    public class GameService
    {
        /// <summary>
        /// Create a new game board with a size of x, y
        /// </summary>
        /// <param name="x"> int height </param>
        /// <param name="y"> int width </param>
        /// <returns> Matrix of GameCell objects with numbered Ids </returns>
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

        public GameCell[,] RandomizeBoard(GameCell[,] board, int x, int y)
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int x1 = random.Next(0, x);
                int x2 = random.Next(0, x);
                int y1 = random.Next(0, y);
                int y2 = random.Next(0, y);

                GameCell holder = board[x1, y1];
                board[x1, y1] = board[x2, y2];
                board[x2, y2] = holder;
            }
            return board;
        }

        // make move

        // check move

        // check winner
        
    }
}
