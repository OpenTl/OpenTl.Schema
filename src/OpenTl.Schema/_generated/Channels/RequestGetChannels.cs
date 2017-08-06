// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa7f6bbb)]
    public class RequestGetChannels : IRequest<Messages.IChats>
    {
       [SerializationOrder(0)]
       public TVector<IInputChannel> Id {get; set;}

    }
}
