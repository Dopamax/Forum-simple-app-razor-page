using Forum_dotnet.Data;
using Forum_dotnet.Models;
namespace Forum_dotnet.Services
{
	public class SubjectService
	{
		private DbForum context = new DbForum();

		public IEnumerable<Subject> getAllSubjectsOfCategorie(int categoryId)
		{
			var subjects = this.context.Subjects.Where(s => s.categoryId == categoryId).ToList().AsEnumerable();

			return subjects;
		}

		public Subject getSubject(int id)
		{
			return this.context.Subjects.Find(id)!;
		}

		public Subject createSubject(Subject subject,int categoryId)
		{
			subject.userId = 1;

			subject.categoryId = categoryId;

			var newSubject = this.context.Subjects.Add(subject);

			this.context.SaveChangesAsync();

			return newSubject.Entity;
		}
	}
}
