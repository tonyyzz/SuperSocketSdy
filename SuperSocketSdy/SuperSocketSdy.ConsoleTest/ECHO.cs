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
		public override string Name
		{
			get { return "01"; }
		}
		public override void ExecuteCommand(TelnetSession session, StringRequestInfo requestInfo)
		{
			switch (requestInfo.Key.ToUpper())
			{
				case ("ECHO"):
					string remoteAddress = session.RemoteEndPoint.Address.ToString();
					session.Send(requestInfo.Body + "   by yzz");
					break;
			}
			
		}
	}
}
