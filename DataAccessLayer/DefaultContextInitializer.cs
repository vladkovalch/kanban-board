using System.Data.Entity;

namespace DataAccessLayer
{
	public class DefaultContextInitializer : DropCreateDatabaseAlways<Context>
	{
		protected override void Seed(Context context)
		{ }
	}
}