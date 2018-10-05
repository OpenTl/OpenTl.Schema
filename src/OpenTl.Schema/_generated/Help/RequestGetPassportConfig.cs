// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc661ad08)]
    public sealed class RequestGetPassportConfig : IRequest<OpenTl.Schema.Help.IPassportConfig>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
