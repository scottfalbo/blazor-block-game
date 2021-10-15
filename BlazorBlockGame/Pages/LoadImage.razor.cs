using BlazorBlockGame.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlockGame.Pages
{
    public partial class LoadImage : ComponentBase
    {
        [Inject] LoadImageService LoadImageService { get; set; }
        [Inject] IWebHostEnvironment Env { get; set; }

        private async Task LoadFile(InputFileChangeEventArgs e)
        {
            IBrowserFile file = e.File;
            Stream stream = file.OpenReadStream();
            string path = $"{Env.WebRootPath}\\{file.Name}";
            FileStream fileStream = File.Create(path);
            await stream.CopyToAsync(fileStream);
            stream.Close();
            fileStream.Close();

            Console.WriteLine(fileStream);
        }
    }
}
