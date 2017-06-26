// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84e53737)]
    public class RequestExportCard : IRequest<TVector<int>>
    {

    }
}
