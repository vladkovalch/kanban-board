using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfConsoleHost
{
	class Program
	{
		static void Main(string[] args)
		{
			// Auto Mapper Configurations
			var mappingConfig = new MapperConfigurator(mc =>
			{
				mc.AddProfile(new MappingProfile());
			});

			IMapper mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);

			services.AddMvc();
		}
	}
}