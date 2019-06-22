using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer;

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