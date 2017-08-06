// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x93d7b347)]
    public class RequestGetMessages : IRequest<Messages.IMessages>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public TVector<int> Id {get; set;}

    }
}
