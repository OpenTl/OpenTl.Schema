// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf635e1b)]
    public class RequestGetInlineGameHighScores : IRequest<Messages.IHighScores>
    {
       [SerializationOrder(0)]
       public IInputBotInlineMessageID Id {get; set;}

       [SerializationOrder(1)]
       public IInputUser UserId {get; set;}

    }
}
