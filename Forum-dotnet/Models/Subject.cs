using System.ComponentModel.DataAnnotations;

namespace Forum_dotnet.Models
{
    public class Subject
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int userId { get; set; }
        public int categoryId { get; set; }
        public DateTime createdAt { get; set; }

        public Subject(int id, string title, string body, int userId, int categoryId, DateTime createdAt)
        {
            this.id = id;
            this.title = title;
            this.body = body;
            this.userId = userId;
            this.categoryId = categoryId;
            this.createdAt = createdAt;
        }

        public Subject()
        {
        }

    }
}
