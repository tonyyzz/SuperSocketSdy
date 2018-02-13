using SuperSocket.SocketBase.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocketSdy.ConsoleTest
{
	[LogTimeCommandFilter]
	public class QUERY : StringCommandBase<TestSession>
	{
		public override void ExecuteCommand(TestSession session, StringRequestInfo requestInfo)
		{
			session.Send(requestInfo.Body + " by yzz");
		}
	}
}
