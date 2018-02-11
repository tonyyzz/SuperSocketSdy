using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	class AVG : CommandBase<TelnetSession, StringRequestInfo>
	{
		public override void ExecuteCommand(TelnetSession session, StringRequestInfo requestInfo)
		{
			switch (requestInfo.Key.ToUpper())
			{
				case ("AVG"):
					session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Average().ToString());
					break;
			}

		}
	}
}
