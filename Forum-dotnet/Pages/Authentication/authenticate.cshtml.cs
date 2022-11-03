using Forum_dotnet.Models;
using Forum_dotnet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forum_dotnet.Pages.Authentication
{
    public class authenticateModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        private UserService userService = new UserService();

        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {
            var newUser = this.userService.login(user.email, user.password);

            if (newUser != null)
            {

                return RedirectToPage("/Forum/Forum");

            }

            return Page();
        }
    }
}
