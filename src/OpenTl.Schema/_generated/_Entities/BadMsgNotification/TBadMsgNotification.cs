// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa7eff811)]
	public sealed class TBadMsgNotification : IBadMsgNotification
	{
       [SerializationOrder(0)]
       public long BadMsgId {get; set;}

       [SerializationOrder(1)]
       public int BadMsgSeqno {get; set;}

       [SerializationOrder(2)]
       public int ErrorCode {get; set;}

	}
}
