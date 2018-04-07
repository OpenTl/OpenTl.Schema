// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x38df3532)]
    public sealed class RequestUpdateDeviceLocked : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int Period {get; set;}

    }
}
