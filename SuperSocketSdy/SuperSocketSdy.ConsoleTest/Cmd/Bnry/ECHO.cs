using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using SuperSocketSdy.ConsoleTest.ServerSession.Bnry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.ConsoleTest.Cmd.Bnry
{
    public class ECHO : CommandBase<BnrySession, BinaryRequestInfo>
    {
        public override string Name
        {
            get { return "01"; }
        }
        public override void ExecuteCommand(BnrySession session, BinaryRequestInfo requestInfo)
        {
            Console.WriteLine($"Body:{requestInfo.Body}");
        }
    }
}
