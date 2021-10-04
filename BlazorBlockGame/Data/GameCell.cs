using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Data
{
    public class GameCell
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string ImageUrl { get; set; }
    }
}
