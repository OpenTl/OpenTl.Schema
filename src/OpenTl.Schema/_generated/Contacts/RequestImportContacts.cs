// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xda30b32d)]
    public class RequestImportContacts : IRequest<Contacts.IImportedContacts>
    {
       [SerializationOrder(0)]
       public TVector<IInputContact> Contacts {get; set;}

       [SerializationOrder(1)]
       public bool Replace {get; set;}

    }
}
