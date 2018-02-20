using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using SuperSocketSdy.ConsoleTest.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.Cmd.Player
{
	public class ECH : CommandBase<PlayerSession, StringRequestInfo>
	{
		public override void ExecuteCommand(PlayerSession session, StringRequestInfo requestInfo)
		{
			session.Send(requestInfo.Body+" by yzz player");
		} 
	}
}
