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
        /// <returns> populated Puzzle object </returns>
        public Puzzle CreateBoard(int x, int y) =>
            new Puzzle(x, y);

        /// <summary>
        /// Randomize the cells on the game board.
        /// </summary>
        /// <param name="board"> GameCell[,] </param>
        /// <param name="x"> int for x index random </param>
        /// <param name="y"> int for y index random </param>
        /// <returns> randomized GameCel[,] </returns>
        public Puzzle RandomizeBoard(Puzzle board, int x, int y)
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new();
                int x1 = random.Next(0, x);
                int x2 = random.Next(0, x);
                int y1 = random.Next(0, y);
                int y2 = random.Next(0, y);

                GameCell holder = board.Rows[x1].Cells[y1];
                if (holder != null)
                {
                    holder.X = x2;
                    holder.Y = y2;
                }

                board.Rows[x1].Cells[y1] = board.Rows[x2].Cells[y2];
                if (board.Rows[x1].Cells[y1] != null)
                {
                    board.Rows[x1].Cells[y1].X = x1;
                    board.Rows[x1].Cells[y1].Y = y1;
                }

                board.Rows[x2].Cells[y2] = holder;
            }
            return board;
        }

        // make move

        // check move

        // check winner

    }
}
