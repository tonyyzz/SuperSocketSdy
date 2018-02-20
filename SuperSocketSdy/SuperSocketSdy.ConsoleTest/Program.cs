using SuperSocket.SocketBase;
using SuperSocketSdy.ConsoleTest.App;
using SuperSocketSdy.ConsoleTest.Telnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{


			new TelnetServerStart().Do();
		}

		
	}
}
