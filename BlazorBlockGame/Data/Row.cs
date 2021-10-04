using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Data
{
    public class Row
    {
        public GameCell[] Cells { get; set; }

        public Row(int y)
        {
            Cells = new GameCell[y];
        }
    }
}
