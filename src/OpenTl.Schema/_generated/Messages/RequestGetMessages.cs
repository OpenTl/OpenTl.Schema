// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4222fa74)]
    public class RequestGetMessages : IRequest<Messages.IMessages>
    {
       [SerializationOrder(0)]
       public TVector<int> Id {get; set;}

    }
}
