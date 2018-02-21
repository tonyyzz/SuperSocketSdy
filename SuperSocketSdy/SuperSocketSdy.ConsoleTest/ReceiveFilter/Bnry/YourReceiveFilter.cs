using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.ReceiveFilter
{
	public class YourReceiveFilter : TerminatorReceiveFilter<BinaryRequestInfo>
	{
		protected YourReceiveFilter(byte[] terminator) : base(terminator)
		{
		}

		//More code
		protected override BinaryRequestInfo ProcessMatchedRequest(byte[] data, int offset, int length)
		{
			return null;
		}
	}
}
