using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.ServerSession.Bnry
{
	public class BnryServerStart
	{
		public void Do()
		{
			var appServer = new BnryServer();
			ServerConfig serverConfig = new ServerConfig
			{
				TextEncoding = Encoding.UTF8.WebName,
				Port = 2012
			};
			//Setup the appServer
			//if (!appServer.Setup(2012)) //Setup with listening port
			Console.WriteLine("服务器启动中...");
			if (!appServer.Setup(serverConfig)) //Setup with listening port
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

			appServer.NewRequestReceived += AppServer_NewRequestReceived;

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

		private void AppServer_NewRequestReceived(BnrySession session, BinaryRequestInfo requestInfo)
		{
			
		}
	}
}
