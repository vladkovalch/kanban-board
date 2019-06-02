using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DataAccessLayer.Models
{
	[Table("Cards")]
	public class Card
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(12)]
		[Required(AllowEmptyStrings = false)]
		public string Name { get; set; }

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime CreationTime { get; set; }

		public Color Color { get; set; }
	}
}
