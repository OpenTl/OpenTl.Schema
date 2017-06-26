// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe22045fc)]
	public class TDestroySessionOk : IDestroySessionRes
	{
       [SerializationOrder(0)]
       public long SessionId {get; set;}

	}
}
