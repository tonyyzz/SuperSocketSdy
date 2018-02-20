using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.ServerSession.Bnry
{
	public class BnrySession : AppSession<BnrySession, BinaryRequestInfo>
	{
		protected override void HandleException(Exception e)
		{
			this.Send("Application error: {0}", e.Message);
		}

		protected override void HandleUnknownRequest(BinaryRequestInfo requestInfo)
		{
			this.Send("Unknow request");
		}

		protected override void OnSessionClosed(CloseReason reason)
		{
			base.OnSessionClosed(reason);
			Console.WriteLine("");
			Console.WriteLine($"远程客户端{this.RemoteEndPoint.Address.ToString()}:{this.RemoteEndPoint.Port}断开连接");

		}

		protected override void OnSessionStarted()
		{
			this.Send("Welcome to SuperSocket Telnet Server");
			Console.WriteLine("");
			Console.WriteLine($"编码：{this.Charset.WebName}");
			Console.WriteLine($"是否连接：{this.Connected}");
			Console.WriteLine($"当前命令：{ this.CurrentCommand}");
			Console.WriteLine($"最后一次激活时间：{this.LastActiveTime.ToString("yyyy-MM-dd HH:mm:ss")}");
			Console.WriteLine($"本地IP端口：{this.LocalEndPoint.Address.ToString()}:{this.LocalEndPoint.Port}");
			Console.WriteLine($"PrevCommand:{this.PrevCommand}");
			Console.WriteLine($"远程IP端口：{this.RemoteEndPoint.Address.ToString()}:{this.RemoteEndPoint.Port}");
			Console.WriteLine($"SessionID:{this.SessionID}");
			Console.WriteLine($"开始时间：{this.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}");
			Console.WriteLine($"安全协议：{this.SecureProtocol.ToString()}");
		}
	}
}
