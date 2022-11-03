using Forum_dotnet.Models;
using Forum_dotnet.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forum_dotnet.Pages.CategoryPage
{
    public class CategoryPageModel : PageModel
    {
        public int categoryId { get; set; }
        public IEnumerable<Subject> subjects { get; set; }

        private SubjectService service = new SubjectService();
        public void OnGet(int id)
        {
            this.categoryId = id;

            this.subjects = this.service.getAllSubjectsOfCategorie(id);
        }
    }
}
