using Forum_dotnet.Data;
using Forum_dotnet.Models;

namespace Forum_dotnet.Services
{
	public class ForumService
	{
		public DbForum context = new DbForum();

		public IEnumerable<Category> getAllCategories()
		{
			var categories = context.Categories.ToList().AsEnumerable();

			return categories;
		}
	}
}
