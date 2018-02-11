using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	class TelnetServer : AppServer<TelnetSession>
	{
		//public TelnetServer() : base(new CommandLineReceiveFilterFactory(Encoding.Default, new BasicRequestInfoParser(":", ",")))
		//{

		//}
		//public TelnetServer() : base(new TerminatorReceiveFilterFactory("##"))
		//{

		//}
		//public TelnetServer() : base(new CountSpliterReceiveFilterFactory((byte)'#', 8))
		//{

		//}
		protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
		{
			return base.Setup(rootConfig, config);
		}

		protected override void OnStartup()
		{
			base.OnStartup();
		}

		protected override void OnStopped()
		{
			base.OnStopped();
		}
	}
}
