using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	[LogTimeCommandFilter]
	public class TestServer:AppServer<TestSession>
	{
	}
}
