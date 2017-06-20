namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x327a30cb)]
    public class RequestSaveGif : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputDocument Id {get; set;}

       [SerializationOrder(1)]
       public bool Unsave {get; set;}

    }
}
