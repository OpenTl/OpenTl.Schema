namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x83bf3d52)]
    public class RequestGetSavedGifs : IRequest<Messages.ISavedGifs>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
