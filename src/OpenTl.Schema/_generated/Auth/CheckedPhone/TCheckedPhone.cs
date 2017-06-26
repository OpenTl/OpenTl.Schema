// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x811ea28e)]
	public class TCheckedPhone : ICheckedPhone
	{
       [SerializationOrder(0)]
       public bool PhoneRegistered {get; set;}

	}
}
