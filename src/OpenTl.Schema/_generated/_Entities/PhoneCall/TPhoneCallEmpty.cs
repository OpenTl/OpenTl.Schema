// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5366c915)]
	public sealed class TPhoneCallEmpty : IPhoneCall, IEmpty
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
