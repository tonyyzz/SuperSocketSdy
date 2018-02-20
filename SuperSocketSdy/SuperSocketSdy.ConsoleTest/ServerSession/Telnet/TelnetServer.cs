using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using SuperSocketSdy.ConsoleTest.ReqInfoParser;

namespace SuperSocketSdy.ConsoleTest.Telnet
{
	public class TelnetServer : AppServer<TelnetSession>
	{

		//自定义协议
		//public TelnetServer()
		//: base(new CommandLineReceiveFilterFactory(Encoding.UTF8,new BasicRequestInfoParser(":",",")))
		//{

		//}

		//public TelnetServer()
		//: base(new CommandLineReceiveFilterFactory(Encoding.UTF8))
		//{

		//}

		[Obsolete]
		protected override void OnStartup()
		{
			base.OnStartup();
		}

		protected override void OnStopped()
		{
			base.OnStopped();
		}

		protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
		{
			return base.Setup(rootConfig, config);
		}
	}
}
