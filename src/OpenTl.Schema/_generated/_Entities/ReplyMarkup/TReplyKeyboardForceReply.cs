// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf4108aa0)]
	public sealed class TReplyKeyboardForceReply : IReplyMarkup
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool SingleUse {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 2)]
       public bool Selective {get; set;}

	}
}
