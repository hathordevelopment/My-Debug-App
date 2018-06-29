using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;


/// <summary>
///     Application apprentissage debogage Visual Studio | Link => https://docs.microsoft.com/fr-fr/visualstudio/debugger/quickstart-debug-aspnet
/// </summary>


namespace MyDbgApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
