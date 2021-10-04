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

        private Puzzle Puzzle;
        private int X;
        private int Y;
        private GameCell RemovedCell;
        private bool Winner;

        protected override void OnInitialized()
        {
            Winner = false;
            X = 3;
            Y = 3;
            Puzzle = GameService.CreateBoard(X, Y);
            RemovedCell = Puzzle.Rows[X - 1].Cells[Y - 1];
            Puzzle.Rows[X - 1].Cells[Y - 1] = null;
            Puzzle = GameService.RandomizeBoard(Puzzle, X, Y);
        }

        public void ClickCell(int x, int y)
        {
            if (!Winner)
            {
                Coords move = GameService.AvailableMove(Puzzle, x, y);

                if (move != null)
                {
                    Puzzle.Rows[move.X].Cells[move.Y] = Puzzle.Rows[x].Cells[y];
                    Puzzle.Rows[move.X].Cells[move.Y].X = move.X;
                    Puzzle.Rows[move.X].Cells[move.Y].Y = move.Y;
                    Puzzle.Rows[x].Cells[y] = null;
                }

                Winner = GameService.CheckWinner(Puzzle);
                if (Winner) Puzzle.Rows[Puzzle.X - 1].Cells[Puzzle.Y - 1] = RemovedCell;
            }
        }
    }
}
