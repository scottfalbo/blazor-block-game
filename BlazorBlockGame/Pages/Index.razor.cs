using BlazorBlockGame.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Pages
{
    public partial class Index
    {
        [Inject] GameService GameService { get; set; }

        private int[,] GameBoard;
        private int X;
        private int Y;

        protected override async Task OnInitializedAsync()
        {
            X = 5;
            Y = 5;
            GameBoard =  GameService.CreateBoard(X, Y);   
        }
    }
}
