﻿using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using SuperSocketSdy.ConsoleTest.ReqInfoParser;
using SuperSocket.Facility.Protocol;
using SuperSocketSdy.ConsoleTest.ReceiveFilter;

namespace SuperSocketSdy.ConsoleTest.Telnet
{
	public class TelnetServer : AppServer<TelnetSession>
	{

		//自定义协议
		//public TelnetServer()
		//: base(new CommandLineReceiveFilterFactory(Encoding.UTF8,new BasicRequestInfoParser(":",",")))
		//{

		//}

		//public TelnetServer()
		//: base(new CommandLineReceiveFilterFactory(Encoding.UTF8))
		//{

		//}

		//结束符协议
		//public TelnetServer()
		//: base(new TerminatorReceiveFilterFactory("##"))
		//{

		//}
		//public TelnetServer()
		//: base(new CountSpliterReceiveFilterFactory((byte)'#', 8))
		//{

		//}

		//固定请求大小协议
		//public TelnetServer()
		//: base(new DefaultReceiveFilterFactory<MyReceiveFilter, StringRequestInfo>()) //使用默认的接受过滤器工厂 (DefaultReceiveFilterFactory)
		//{

		//}

		[Obsolete]
		protected override void OnStartup()
		{
			base.OnStartup();
		}

		protected override void OnStopped()
		{
			base.OnStopped();
		}

		protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
		{
			return base.Setup(rootConfig, config);
		}
	}
}
