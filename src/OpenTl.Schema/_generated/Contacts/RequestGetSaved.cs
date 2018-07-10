// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x82f1e39f)]
    public sealed class RequestGetSaved : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ISavedContact>>
    {

    }
}
