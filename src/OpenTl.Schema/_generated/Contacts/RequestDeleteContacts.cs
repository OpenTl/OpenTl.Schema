namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x59ab389e)]
    public class RequestDeleteContacts : IRequest<bool>
    {
       [SerializationOrder(0)]
       public TVector<IInputUser> Id {get; set;}

    }
}
