// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4fe196fe)]
    public class RequestImportCard : IRequest<IUser>
    {
       [SerializationOrder(0)]
       public TVector<int> ExportCard {get; set;}

    }
}
