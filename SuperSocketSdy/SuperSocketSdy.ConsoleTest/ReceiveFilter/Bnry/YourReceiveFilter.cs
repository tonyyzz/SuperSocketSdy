using SuperSocket.Common;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.ReceiveFilter
{
	public class YourReceiveFilter : TerminatorReceiveFilter<BinaryRequestInfo>
	{
		public YourReceiveFilter() : base(new byte[] { })
		{

		}
		protected YourReceiveFilter(byte[] terminator) : base(terminator)
		{
		}

		//More code
		protected override BinaryRequestInfo ProcessMatchedRequest(byte[] data, int offset, int length)
		{
			return new BinaryRequestInfo(Encoding.UTF8.GetString(data, offset, 4), data.CloneRange(offset, length));

		}
	}
}
