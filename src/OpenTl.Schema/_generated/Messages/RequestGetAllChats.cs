// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeba80ff0)]
    public class RequestGetAllChats : IRequest<Messages.IChats>
    {
       [SerializationOrder(0)]
       public TVector<int> ExceptIds {get; set;}

    }
}
