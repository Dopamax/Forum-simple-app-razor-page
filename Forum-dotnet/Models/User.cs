using System.ComponentModel.DataAnnotations;

namespace Forum_dotnet.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime createdAt { get; set; }

        public User(int id, string name, string email, string password, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.createdAt = createdAt;
        }

        public User()
        {
        }
    }
}
