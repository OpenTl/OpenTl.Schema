// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6628562c)]
    public sealed class RequestUpdateStatus : IRequest<bool>
    {
       [SerializationOrder(0)]
       public bool Offline {get; set;}

    }
}
