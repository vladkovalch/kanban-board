using System;
using System.Drawing;

namespace BusinessLogicLayer.DTO
{
	public class CardDTO
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime CreationTime { get; set; }

		public Color Color { get; set; }
	}
}
