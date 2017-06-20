namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9cb126e)]
    public class RequestCreateChat : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public TVector<IInputUser> Users {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

    }
}
