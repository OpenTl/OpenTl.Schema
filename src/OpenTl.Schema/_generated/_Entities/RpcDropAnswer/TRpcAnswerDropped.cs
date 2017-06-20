namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa43ad8b7)]
	public class TRpcAnswerDropped : IRpcDropAnswer
	{
       [SerializationOrder(0)]
       public long MsgId {get; set;}

       [SerializationOrder(1)]
       public int SeqNo {get; set;}

       [SerializationOrder(2)]
       public int Bytes {get; set;}

	}
}
