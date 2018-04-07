// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x276d3ec6)]
	public sealed class TMsgDetailedInfo : IMsgDetailedInfo
	{
       [SerializationOrder(0)]
       public long MsgId {get; set;}

       [SerializationOrder(1)]
       public long AnswerMsgId {get; set;}

       [SerializationOrder(2)]
       public int Bytes {get; set;}

       [SerializationOrder(3)]
       public int Status {get; set;}

	}
}
