// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcc104937)]
    public class RequestReadHistory : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

    }
}
