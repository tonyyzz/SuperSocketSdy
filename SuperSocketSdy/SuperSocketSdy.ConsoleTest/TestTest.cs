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
			Console.WriteLine("The server started successfully, press key 'q' to stop it!");
			Console.ReadKey();
		}
	}
}
