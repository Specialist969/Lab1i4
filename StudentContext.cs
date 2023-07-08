using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1i4
{
	//public class StudentContext : IdentityDbContext<UserEntity, UserRole, int>
	public class StudentContext : DbContext
	{
		public StudentContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Student> Student { get; set; } = null!;
	}
}
