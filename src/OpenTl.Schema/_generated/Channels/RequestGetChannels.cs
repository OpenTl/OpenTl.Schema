// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa7f6bbb)]
    public sealed class RequestGetChannels : IRequest<OpenTl.Schema.Messages.IChats>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputChannel> Id {get; set;}

    }
}
