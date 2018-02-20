using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.Telnet
{
	public class TelnetServerStart
	{
		public void Do()
		{
			var appServer = new TelnetServer();

			//Setup the appServer
			if (!appServer.Setup(2012)) //Setup with listening port
			{
				Console.WriteLine("Failed to setup!");
				Console.ReadKey();
				return;
			}

			Console.WriteLine();

			//Try to start the appServer
			if (!appServer.Start())
			{
				Console.WriteLine("Failed to start!");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("The server started successfully, press key 'q' to stop it!");

			//appServer.NewSessionConnected += AppServer_NewSessionConnected;
			//appServer.NewRequestReceived += AppServer_NewRequestReceived;

			while (Console.ReadKey().KeyChar != 'q')
			{
				Console.WriteLine();
				continue;
			}

			//Stop the appServer
			appServer.Stop();

			Console.WriteLine("The server was stopped!");
			Console.ReadKey();
		}
	}
}
