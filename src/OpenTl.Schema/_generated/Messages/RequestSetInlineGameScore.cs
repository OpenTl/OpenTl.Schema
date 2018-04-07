// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x15ad9f64)]
    public sealed class RequestSetInlineGameScore : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool EditMessage {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Force {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputBotInlineMessageID Id {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(5)]
       public int Score {get; set;}

    }
}
