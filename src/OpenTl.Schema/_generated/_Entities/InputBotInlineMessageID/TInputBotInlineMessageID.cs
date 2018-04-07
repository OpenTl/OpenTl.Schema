// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x890c3d89)]
	public sealed class TInputBotInlineMessageID : IInputBotInlineMessageID
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       [SerializationOrder(1)]
       public long Id {get; set;}

       [SerializationOrder(2)]
       public long AccessHash {get; set;}

	}
}
