using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketSdy.ConsoleTest.Sessions
{
	public class PlayerSession : AppSession<PlayerSession>
	{
		public int GameHallId { get; internal set; }

		public int RoomId { get; internal set; }
	}
}
