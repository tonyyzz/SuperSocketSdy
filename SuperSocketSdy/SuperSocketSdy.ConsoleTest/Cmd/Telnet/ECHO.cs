using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using SuperSocketSdy.ConsoleTest.Telnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.Cmd.Telnet
{
	public class ECHO : CommandBase<TelnetSession, StringRequestInfo>
	{
		public override void ExecuteCommand(TelnetSession session, StringRequestInfo requestInfo)
		{
			Console.WriteLine($"Body:{requestInfo.Body}");
			session.Send(requestInfo.Body + " by yzz telnet");
		}
	}
}
