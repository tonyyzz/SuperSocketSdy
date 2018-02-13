using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	public class TestTest
	{
		public void Do()
		{
			var testServer = new TestServer();
			Console.WriteLine( testServer.Setup(2012));
			Console.WriteLine( testServer.Start());
			testServer.NewRequestReceived += new QUERY().ExecuteCommand;
			testServer.NewSessionConnected += TestServer_NewSessionConnected;
			testServer.SessionClosed += TestServer_SessionClosed;
			Console.WriteLine("The server started successfully, press key 'q' to stop it!");
			Console.ReadKey();
		}

		private void TestServer_SessionClosed(TestSession session, SuperSocket.SocketBase.CloseReason reason)
		{
			Console.WriteLine("A session is closed for {0}.", reason);
		}

		private void TestServer_NewSessionConnected(TestSession session)
		{
			Console.WriteLine("有新连接");
			session.Send("Welcome to SuperSocket Telnet Server");
		}
	}
}
