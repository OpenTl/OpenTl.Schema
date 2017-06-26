// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2144ca19)]
	public class TRpcError : IObject
	{
       [SerializationOrder(0)]
       public int ErrorCode {get; set;}

       [SerializationOrder(1)]
       public string ErrorMessage {get; set;}

	}
}
