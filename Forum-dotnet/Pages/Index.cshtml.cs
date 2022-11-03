using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forum_dotnet.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (HttpContext.Session.GetString("auth") == null)
            {
                @ViewData["auth"] = "null";
            }
            else
            {
                @ViewData["auth"] = HttpContext.Session.GetString("auth");
            }
        }
    }
}