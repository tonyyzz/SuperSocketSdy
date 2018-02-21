using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.ReceiveFilter
{
	public class MyReceiveFilter : FixedSizeReceiveFilter<StringRequestInfo>
	{
		public MyReceiveFilter() : base(9) //传入固定的请求大小
		{
		}

		protected override StringRequestInfo ProcessMatchedRequest(byte[] buffer, int offset, int length, bool toBeCopied)
		{
			throw new NotImplementedException();
		}
	}
}
