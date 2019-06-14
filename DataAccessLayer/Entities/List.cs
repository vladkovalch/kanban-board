using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
	[Table("Lists")]
	public class List
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(24)]
		[Required(AllowEmptyStrings = false)]
		public string Name { get; set; }

		public ICollection<Card> Cards { get; set; }
	}
}