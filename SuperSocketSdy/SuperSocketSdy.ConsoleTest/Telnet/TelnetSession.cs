using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocketSdy.ConsoleTest.Telnet
{
	public class TelnetSession : AppSession<TelnetSession>
	{
		protected override void HandleException(Exception e)
		{
			this.Send("Application error: {0}", e.Message);
		}

		protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
		{
			this.Send("Unknow request");
		}

		protected override void OnSessionClosed(CloseReason reason)
		{
			//add you logics which will be executed after the session is closed
			base.OnSessionClosed(reason);
		}

		protected override void OnSessionStarted()
		{
			this.Send("Welcome to SuperSocket Telnet Server");
		}
	}
}
