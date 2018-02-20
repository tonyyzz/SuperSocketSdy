using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Config;

namespace SuperSocketSdy.ConsoleTest.ServerSession.Bnry
{
	public class BnryServer : AppServer<BnrySession, BinaryRequestInfo>
	{
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
