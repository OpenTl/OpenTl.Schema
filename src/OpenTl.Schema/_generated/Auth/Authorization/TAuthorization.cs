// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcd050916)]
	public sealed class TAuthorization : IAuthorization
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int TmpSessions {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IUser User {get; set;}

	}
}
