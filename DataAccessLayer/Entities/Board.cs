using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
	[Table("Boards")]
	public class Board
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(24)]
		[Required(AllowEmptyStrings = false)]
		public string Name { get; set; }
		
		[MaxLength(64)]
		[Required(AllowEmptyStrings = false)]
		public string Description { get; set; }

		public ICollection<List> Lists { get; set; }
		public ICollection<User> Users { get; set; }
	}
}
