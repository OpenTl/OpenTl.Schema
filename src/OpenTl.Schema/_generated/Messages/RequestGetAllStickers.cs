namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c9618b1)]
    public class RequestGetAllStickers : IRequest<Messages.IAllStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
