// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x811ea28e)]
	public sealed class TCheckedPhone : IObject
	{
       [SerializationOrder(0)]
       public bool PhoneRegistered {get; set;}

	}
}
