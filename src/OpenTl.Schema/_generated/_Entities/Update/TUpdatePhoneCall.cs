// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xab0f6b1e)]
	public sealed class TUpdatePhoneCall : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPhoneCall PhoneCall {get; set;}

	}
}
