using Forum_dotnet.Data;
using Forum_dotnet.Models;

namespace Forum_dotnet.Services
{
    public class UserService
    {
        public DbForum context = new DbForum();

        public User login(string email, string password)
        {

            var user = context.Users.Where(u => u.email == email).FirstOrDefault()!;

            if (user.password.Equals(password))
            {

                return user;

            }

            return null!;

        }

        public User register(User newUser)
        {
            var user = context.Users.Add(newUser);

            context.SaveChanges();

            return user.Entity;
        }

        public User getAuthor(int subjectId)
        {
            var subject = context.Subjects.Find(subjectId)!;

            var user = context.Users.Find(subject.userId)!;

            return user;
        }
    }
}
