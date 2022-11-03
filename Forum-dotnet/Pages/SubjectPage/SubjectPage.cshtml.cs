using Forum_dotnet.Models;
using Forum_dotnet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forum_dotnet.Pages.SubjectPage
{
    public class SubjectPageModel : PageModel
    {
        public SubjectService subjectService = new SubjectService();

        public UserService userService = new UserService();
        [BindProperty]
        public Subject subject { get; set; }
        [BindProperty]
        public User user { get; set; }

        public void OnGet(int id)
        {
            this.user = this.userService.getAuthor(id);

            this.subject = this.subjectService.getSubject(id);
        }
    }
}
