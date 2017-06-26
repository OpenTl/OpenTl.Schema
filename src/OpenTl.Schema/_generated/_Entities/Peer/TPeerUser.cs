// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9db1bc6d)]
	public class TPeerUser : IPeer
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
