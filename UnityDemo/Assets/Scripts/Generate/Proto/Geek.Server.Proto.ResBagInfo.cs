//auto generated, do not modify it

using Protocol;
using MessagePack;
using System.Collections.Generic;

namespace Geek.Server.Proto
{
	[MessagePackObject(true)]
	public class ResBagInfo : Message
	{
		[IgnoreMember]
		public const int Sid = -1872884227;

		[IgnoreMember]
		public const int MsgID = Sid;
		[IgnoreMember]
		public override int MsgId => MsgID;

        public Dictionary<int, long> ItemDic { get; set; } = new Dictionary<int, long>();
	}
}
