using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SuperSocketSdy.StressTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//1K字节
			var str = "构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台机构建5000个连接的请求测试(测试电脑是一台笔记本),请求消息大小为1K;构建一个简单的TCP服务,然后在另一台";

			Console.Write("请输入连接数：");
			var connCount = Convert.ToInt32(Console.ReadLine());

			int interval = 50;

			for (int i = 0; i < connCount; i++)
			{
				ThreadPool.QueueUserWorkItem(m =>
				{
					Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					//IPAddress ip = IPAddress.Parse("127.0.0.1");
					IPAddress ip = IPAddress.Parse("111.230.142.94");
					IPEndPoint point = new IPEndPoint(ip, 8088);
					//进行连接
					socketClient.Connect(point);

					Thread thread = new Thread(Recive)
					{
						IsBackground = true
					};
					thread.Start(socketClient);

					var buffter = Encoding.UTF8.GetBytes($"01 {str}\r\n");
					//CountSpliterReceiveFilter - 固定数量分隔符协议
					//var buffter = Encoding.UTF8.GetBytes($" ECHO#part1#part2#part3#part4#part5#part6#{i}#");
					//var buffter = Encoding.ASCII.GetBytes($"KILL BILL");
					while (true)
					{


						var temp = socketClient.Send(buffter);
						Thread.Sleep(interval);
					}

					//new Thread(n =>
					//{
					//	var send = n as Socket;
					//	while (true)

					//	{
					//		//内置默认命令行协议
					//		//var buffter = Encoding.UTF8.GetBytes($"ECHO Test Send Message:{i}\r\n");
					//		var buffter = Encoding.UTF8.GetBytes($"01 {str}\r\n");
					//		//CountSpliterReceiveFilter - 固定数量分隔符协议
					//		//var buffter = Encoding.UTF8.GetBytes($" ECHO#part1#part2#part3#part4#part5#part6#{i}#");
					//		//var buffter = Encoding.ASCII.GetBytes($"KILL BILL");
					//		var temp = send.Send(buffter);
					//		Thread.Sleep(interval);
					//	}
					//})
					//{  IsBackground=true}.Start(socketClient);
					

				});
				//new Thread(o =>
				//{
				//	Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				//	IPAddress ip = IPAddress.Parse("127.0.0.1");
				//	IPEndPoint point = new IPEndPoint(ip, 2012);
				//	//进行连接
				//	socketClient.Connect(point);
				//})
				//{ IsBackground = true }.Start();
			}
			while (true)
			{
				Console.ReadKey();
			}
		}

		/// <summary>
		/// 接收消息
		/// </summary>
		/// <param name="o"></param>
		static void Recive(object o)
		{
			var send = o as Socket;
			while (true)
			{
				//获取发送过来的消息
				byte[] buffer = new byte[1024 * 1024 * 2];
				var effective = send.Receive(buffer);
				if (effective == 0)
				{
					break;
				}
				//var str = Encoding.UTF8.GetString(buffer, 0, effective);
				//Console.WriteLine(str);
			}
		}
	}
}
