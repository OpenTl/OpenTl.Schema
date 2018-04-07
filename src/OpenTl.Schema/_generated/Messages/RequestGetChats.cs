// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3c6aa187)]
    public sealed class RequestGetChats : IRequest<OpenTl.Schema.Messages.IChats>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

    }
}
