using Forum_dotnet.Models;
using Forum_dotnet.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forum_dotnet.Pages.Forum
{
    public class ForumModel : PageModel
    {
        public IEnumerable<Category> categories { get; set; }

        ForumService service = new ForumService();
        public void OnGet()
        {
     
            this.categories = this.service.getAllCategories();

        }
    }
}
