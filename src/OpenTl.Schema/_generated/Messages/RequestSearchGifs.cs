// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbf9a776b)]
    public class RequestSearchGifs : IRequest<Messages.IFoundGifs>
    {
       [SerializationOrder(0)]
       public string Q {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

    }
}
