// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x809db6df)]
	public sealed class TMsgNewDetailedInfo : IMsgDetailedInfo
	{
       [SerializationOrder(0)]
       public long AnswerMsgId {get; set;}

       [SerializationOrder(1)]
       public int Bytes {get; set;}

       [SerializationOrder(2)]
       public int Status {get; set;}

	}
}
