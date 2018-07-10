// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc4a353ee)]
    public sealed class RequestGetStatuses : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IContactStatus>>
    {

    }
}
