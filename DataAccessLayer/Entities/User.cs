using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

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

		private string _password;
		[MaxLength(64)]
		[Required(AllowEmptyStrings = false)]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")]
		public string Sha256Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = ComputeSha256Hash(value);
			}
		}
		
		static string ComputeSha256Hash(string rawData)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}

		[ForeignKey("Profile")]
		public int ProfileId { get; set; }
		public UserProfile Profile { get; set; }

		public ICollection<Board> Boards { get; set; }
	}
}
