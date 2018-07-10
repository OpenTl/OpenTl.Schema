// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8341ecc0)]
    public sealed class RequestGetLeftChannels : IRequest<OpenTl.Schema.Messages.IChats>
    {
       [SerializationOrder(0)]
       public int Offset {get; set;}

    }
}
