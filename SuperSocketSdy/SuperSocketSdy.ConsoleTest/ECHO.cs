﻿using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	class ECHO : CommandBase<TelnetSession, StringRequestInfo>
	{
		public override void ExecuteCommand(TelnetSession session, StringRequestInfo requestInfo)
		{
			session.Send(requestInfo.Body+"   by yzz");
		}
	}
}
