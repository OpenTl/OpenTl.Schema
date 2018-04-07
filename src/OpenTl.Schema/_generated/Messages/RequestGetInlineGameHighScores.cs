// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf635e1b)]
    public sealed class RequestGetInlineGameHighScores : IRequest<OpenTl.Schema.Messages.IHighScores>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputBotInlineMessageID Id {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

    }
}
