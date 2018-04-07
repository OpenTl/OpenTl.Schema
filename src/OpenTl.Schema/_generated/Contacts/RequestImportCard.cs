// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4fe196fe)]
    public sealed class RequestImportCard : IRequest<OpenTl.Schema.IUser>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> ExportCard {get; set;}

    }
}
