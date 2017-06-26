// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x65b8c79f)]
    public class RequestGetMaskStickers : IRequest<Messages.IAllStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
