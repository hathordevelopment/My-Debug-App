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
            LinkedList<int> result = doWork();
            Message = "Result of work: " + result.First.Value + ", " + result.First.Value;
        }

        private static LinkedList<int> doWork()
        {
            LinkedList<int> c1 = new LinkedList<int>();

            c1.AddLast(10);
            c1.AddLast(20);

            LinkedList<int> c2 = new LinkedList<int>(c1);

            return c2;

        }
    }
}
