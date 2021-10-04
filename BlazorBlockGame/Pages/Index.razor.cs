using BlazorBlockGame.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Pages
{
    public partial class Index
    {
        [Inject] GameService GameService { get; set; }

        private GameCell[,] GameBoard;
        private int X;
        private int Y;
        private GameCell RemovedCell;

        protected override void OnInitialized()
        {
            X = 5;
            Y = 5;
            GameBoard =  GameService.CreateBoard(X, Y);
            RemovedCell = GameBoard[X - 1, Y - 1];
            GameBoard[X - 1, Y - 1] = null;
            GameBoard = GameService.RandomizeBoard(GameBoard, X, Y);
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
