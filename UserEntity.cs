using Microsoft.AspNetCore.Identity;

namespace Lab1i4
{
	public class UserEntity : IdentityRole<int>
	{
		public object Email { get; internal set; }
		public object UserName { get; internal set; }
	}
}
