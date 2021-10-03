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

        private string Testing;

        protected override async Task OnInitializedAsync()
        {
            Testing = GameService.Hello;
        }
    }
}
