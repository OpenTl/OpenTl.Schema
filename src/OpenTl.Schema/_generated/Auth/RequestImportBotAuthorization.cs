// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x67a3ff2c)]
    public class RequestImportBotAuthorization : IRequest<Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public int Flags {get; set;}

       [SerializationOrder(1)]
       public int ApiId {get; set;}

       [SerializationOrder(2)]
       public string ApiHash {get; set;}

       [SerializationOrder(3)]
       public string BotAuthToken {get; set;}

    }
}
