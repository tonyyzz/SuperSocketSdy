using SuperSocket.SocketBase.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.Common;

namespace SuperSocketSdy.ConsoleTest.Attr
{
	public class LogTimeCommandFilterAttribute : CommandFilterAttribute
	{
		public override void OnCommandExecuted(CommandExecutingContext commandContext)
		{
			var session = commandContext.Session;
			var startTime = session.Items.GetValue<DateTime>("StartTime");
			var ts = DateTime.Now.Subtract(startTime);

			if (ts.TotalSeconds > 5 && session.Logger.IsInfoEnabled)
			{
				session.Logger.InfoFormat("A command '{0}' took {1} seconds!", commandContext.CurrentCommand.Name, ts.ToString());
			}
		}

		public override void OnCommandExecuting(CommandExecutingContext commandContext)
		{
			commandContext.Session.Items["StartTime"] = DateTime.Now;
		}
	}
}
