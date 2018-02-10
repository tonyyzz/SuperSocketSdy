using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//var appServer = new AppServer();
			//if (!appServer.Setup(2012)) //Setup with listening port
			//{
			//	Console.WriteLine("Failed to setup!");
			//	Console.ReadKey();
			//	return;
			//}
			//Console.WriteLine();

			////Try to start the appServer
			//if (!appServer.Start())
			//{
			//	Console.WriteLine("Failed to start!");
			//	Console.ReadKey();
			//	return;
			//}

			////注册回话新建事件处理方法
			//appServer.NewSessionConnected += AppServer_NewSessionConnected;
			////注册请求处理方法
			////appServer.NewRequestReceived += AppServer_NewRequestReceived;
			////要单独拎出来
			////appServer.NewRequestReceived += new ECHO().ExecuteCommand;
			//appServer.NewRequestReceived += new ADD().ExecuteCommand;
			//appServer.NewRequestReceived += new MULT().ExecuteCommand;

			//Console.WriteLine("The server started successfully, press key 'q' to stop it!");

			//while (Console.ReadKey().KeyChar != 'q')
			//{
			//	Console.WriteLine();
			//	continue;
			//}

			////Stop the appServer
			//appServer.Stop();

			//Console.WriteLine("The server was stopped!");
			//Console.ReadKey();


			//var telnetServer = new TelnetServer();
			//telnetServer.Setup(2012);
			//telnetServer.Start();
			//telnetServer.NewRequestReceived += new ECHO().ExecuteCommand;
			//Console.WriteLine("The server started successfully, press key 'q' to stop it!");
			//Console.ReadKey();



			//Console.WriteLine("Press any key to start the server!");

			//Console.ReadKey();
			//Console.WriteLine();

			var bootstrap = BootstrapFactory.CreateBootstrap();

			if (!bootstrap.Initialize())
			{
				Console.WriteLine("Failed to initialize!");
				Console.ReadKey();
				return;
			}

			var result = bootstrap.Start();

			Console.WriteLine("Start result: {0}!", result);

			if (result == StartResult.Failed)
			{
				Console.WriteLine("Failed to start!");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("Press key 'q' to stop it!");

			while (Console.ReadKey().KeyChar != 'q')
			{
				Console.WriteLine();
				continue;
			}

			Console.WriteLine();

			//Stop the appServer
			bootstrap.Stop();

			Console.WriteLine("The server was stopped!");
			Console.ReadKey();

		}

		private static void AppServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
		{
			switch (requestInfo.Key.ToUpper())
			{
				case ("ECHO"):
					session.Send(requestInfo.Body);
					break;

				case ("ADD"):
					session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
					break;

				case ("MULT"):

					var result = 1;

					foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p)))
					{
						result *= factor;
					}

					session.Send(result.ToString());
					break;
			}
		}

		private static void AppServer_NewSessionConnected(AppSession session)
		{
			session.Send("Welcome to SuperSocket Telnet Server");
		}
	}
}
