using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest
{
	class PlayerSession : AppSession<PlayerSession>
	{
		public int GameHallId { get; internal set; }

		public int RoomId { get; internal set; }
	}
}
