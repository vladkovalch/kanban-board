using System;

namespace WcfConsoleHost
{
	class Program
	{
		static void Main(string[] args)
		{
			Configurator configurator = new Configurator();
			configurator.Configure(Console.Out);

			while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
		}
	}
}