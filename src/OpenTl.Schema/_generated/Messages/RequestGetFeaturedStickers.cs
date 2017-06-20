namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2dacca4f)]
    public class RequestGetFeaturedStickers : IRequest<Messages.IFeaturedStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
