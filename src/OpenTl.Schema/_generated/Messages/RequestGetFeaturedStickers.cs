// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2dacca4f)]
    public sealed class RequestGetFeaturedStickers : IRequest<OpenTl.Schema.Messages.IFeaturedStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
