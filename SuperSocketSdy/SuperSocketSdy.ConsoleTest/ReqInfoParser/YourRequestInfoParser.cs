using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.ReqInfoParser
{
	public class YourRequestInfoParser : IRequestInfoParser<StringRequestInfo>
	{
		public StringRequestInfo ParseRequestInfo(string source)
		{
			Console.WriteLine($"source:{source}");
			//return new StringRequestInfo()
			return null;
		}
	}
}
