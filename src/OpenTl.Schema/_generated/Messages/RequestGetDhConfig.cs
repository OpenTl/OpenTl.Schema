// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x26cf8950)]
    public sealed class RequestGetDhConfig : IRequest<OpenTl.Schema.Messages.IDhConfig>
    {
       [SerializationOrder(0)]
       public int Version {get; set;}

       [SerializationOrder(1)]
       public int RandomLength {get; set;}

    }
}
