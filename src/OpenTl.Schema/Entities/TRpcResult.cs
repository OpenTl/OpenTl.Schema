// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf35c6d01)]
	public sealed class TRpcResult : IObject
	{
       [SerializationOrder(0)]
       public long ReqMsgId {get; set;}

       [SerializationOrder(1)]
       public byte[] Result {get; set;}

	}
}
