using Newtonsoft.Json;
using SuperSocketSdy.ConsoleTest.Telnet;
using System;

namespace SuperSocketSdy.CoreConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			new TelnetServerStart().Do();
		}
	}
}
