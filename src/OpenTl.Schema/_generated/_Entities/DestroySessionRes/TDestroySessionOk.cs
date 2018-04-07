// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe22045fc)]
	public sealed class TDestroySessionOk : IDestroySessionRes
	{
       [SerializationOrder(0)]
       public long SessionId {get; set;}

	}
}
