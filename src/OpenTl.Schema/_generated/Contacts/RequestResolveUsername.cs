namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf93ccba3)]
    public class RequestResolveUsername : IRequest<Contacts.IResolvedPeer>
    {
       [SerializationOrder(0)]
       public string Username {get; set;}

    }
}
