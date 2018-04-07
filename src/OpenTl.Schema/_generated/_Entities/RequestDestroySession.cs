// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe7512126)]
    public sealed class RequestDestroySession : IRequest<OpenTl.Schema.IDestroySessionRes>
    {
       [SerializationOrder(0)]
       public long SessionId {get; set;}

    }
}
