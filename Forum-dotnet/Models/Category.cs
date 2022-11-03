using System.ComponentModel.DataAnnotations;

namespace Forum_dotnet.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category(int id, string name, DateTime createdAt)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
        }

        public Category()
        {
        }
    }
}
