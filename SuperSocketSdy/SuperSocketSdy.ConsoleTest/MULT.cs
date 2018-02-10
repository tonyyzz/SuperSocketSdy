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
	class MULT : CommandBase<AppSession, StringRequestInfo>
	{
		public override void ExecuteCommand(AppSession session, StringRequestInfo requestInfo)
		{
			switch (requestInfo.Key.ToUpper())
			{
				
				case ("MULT"):

					var result = 1;

					foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p)))
					{
						result *= factor;
					}

					session.Send(result.ToString());
					break;
			}
			
		}
	}
}
