// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84e53737)]
    public sealed class RequestExportCard : IRequest<OpenTl.Schema.TVector<int>>
    {

    }
}
