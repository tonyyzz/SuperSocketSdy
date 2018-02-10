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
	class ADD : CommandBase<AppSession, StringRequestInfo>
	{
		public override void ExecuteCommand(AppSession session, StringRequestInfo requestInfo)
		{
			switch (requestInfo.Key.ToUpper())
			{
				case ("ADD"):
					session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
					break;
			}
			
		}
	}
}
