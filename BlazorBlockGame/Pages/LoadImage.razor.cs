using BlazorBlockGame.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Pages
{
    public partial class LoadImage : ComponentBase
    {
        [Inject] LoadImageService LoadImageService { get; set; }
        private void LoadFile(InputFileChangeEventArgs e)
        {
            Console.WriteLine("");
        }
    }
}
