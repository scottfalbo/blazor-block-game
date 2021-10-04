using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Data
{
    public class Puzzle
    {
        public Row[] Rows { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Puzzle(int x, int y)
        {
            X = x;
            Y = y;
            int counter = 1;
            Rows = new Row[x];

            for (int i = 0; i < x; i++)
            {
                Rows[i] = new Row(y);
                for (int j = 0; j < y; j++)
                {
                    Rows[i].Cells[j] = new GameCell()
                    {
                        Id = counter,
                        X = i,
                        Y = j,
                        ImageUrl = $"someurl_{counter}"
                    };
                    counter++;
                }
            }
        }
    }
}
