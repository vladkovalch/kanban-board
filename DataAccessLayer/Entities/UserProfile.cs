using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
	[Table("UserProfiles")]
	public class UserProfile
	{
		[Key, ForeignKey("User")]
		public int Id { get; set; }
		public User User { get; set; }

		[MaxLength(24)]
		[Required(AllowEmptyStrings = false)]
		public string FirstName { get; set; }

		[MaxLength(42)]
		[Required(AllowEmptyStrings = false)]
		public string SecondName { get; set; }
		
		[MaxLength(byte.MaxValue)]
		[Required(AllowEmptyStrings = false)]
		public string ImagePath { get; set; }
	}
}
