using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
	[Table("Users")]
	public class User
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(64)]
		[Required(AllowEmptyStrings = false)]
		[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
		public string Email { get; set; }

		[MaxLength(256)]
		[Required(AllowEmptyStrings = false)]
		public string Sha256Password { get; set; }

		[ForeignKey("Profile")]
		public int ProfileId { get; set; }
		public UserProfile Profile { get; set; }

		public ICollection<Board> Boards { get; set; }
	}
}