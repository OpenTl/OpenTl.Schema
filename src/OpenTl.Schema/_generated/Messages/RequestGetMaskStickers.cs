// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x65b8c79f)]
    public sealed class RequestGetMaskStickers : IRequest<OpenTl.Schema.Messages.IAllStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
