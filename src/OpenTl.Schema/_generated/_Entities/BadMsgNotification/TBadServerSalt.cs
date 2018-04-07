// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedab447b)]
	public sealed class TBadServerSalt : IBadMsgNotification
	{
       [SerializationOrder(0)]
       public long BadMsgId {get; set;}

       [SerializationOrder(1)]
       public int BadMsgSeqno {get; set;}

       [SerializationOrder(2)]
       public int ErrorCode {get; set;}

       [SerializationOrder(3)]
       public long NewServerSalt {get; set;}

	}
}
