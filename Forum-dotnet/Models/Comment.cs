using System.ComponentModel.DataAnnotations;

namespace Forum_dotnet.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string text { get; set; }
        public int subjectId { get; set; }
        public int userId { get; set; }
        public DateTime createdAt { get; set; }

        public Comment(int id, string text, int subjectId, int userId, DateTime createdAt)
        {
            this.id = id;
            this.text = text;
            this.subjectId = subjectId;
            this.userId = userId;
            this.createdAt = createdAt;
        }

        public Comment()
        {
        }
    }
}
