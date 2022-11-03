using Forum_dotnet.Models;
using Forum_dotnet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forum_dotnet.Pages.CreateSubjectPage
{
    public class CreateSubjectPageModel : PageModel
    {
        [BindProperty]
        public Subject subject { get; set; }

        public SubjectService subjectService = new SubjectService();
        public void OnGet()
        {
        }

        public IActionResult OnPost(int categoryId)
        {

           var newSubject =  this.subjectService.createSubject(this.subject, categoryId);

           return RedirectToPage("/CategoryPage/CategoryPage", new { id = newSubject.categoryId });

        }
    }
}
