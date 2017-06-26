// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3c6aa187)]
    public class RequestGetChats : IRequest<Messages.IChats>
    {
       [SerializationOrder(0)]
       public TVector<int> Id {get; set;}

    }
}
