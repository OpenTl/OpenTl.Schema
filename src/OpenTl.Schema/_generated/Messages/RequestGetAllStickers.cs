// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c9618b1)]
    public sealed class RequestGetAllStickers : IRequest<OpenTl.Schema.Messages.IAllStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
