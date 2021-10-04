using BlazorBlockGame.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Pages
{
    public partial class GameBoard
    {
        [Inject] GameService GameService { get; set; }

        private GameCell[,] Board;
        private int X;
        private int Y;
        private GameCell RemovedCell;

        protected override void OnInitialized()
        {
            X = 5;
            Y = 5;
            Board = GameService.CreateBoard(X, Y);
            RemovedCell = Board[X - 1, Y - 1];
            Board[X - 1, Y - 1] = null;
            Board = GameService.RandomizeBoard(Board, X, Y);
        }

        public void ClickCell(int x, int y)
        {
            Console.WriteLine("");
            // check around open space
            // board edges
            // move into if
            // check for winner
        }
    }
}
