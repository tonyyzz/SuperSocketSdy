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
			for (int i = 0; i < 100; i++)
			{
				ThreadPool.QueueUserWorkItem(m => {
					Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					IPAddress ip = IPAddress.Parse("127.0.0.1");
					IPEndPoint point = new IPEndPoint(ip, 2012);
					//进行连接
					socketClient.Connect(point);
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
	}
}
