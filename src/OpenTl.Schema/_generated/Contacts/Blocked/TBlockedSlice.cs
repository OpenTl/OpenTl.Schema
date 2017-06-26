// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x900802a1)]
	public class TBlockedSlice : IBlocked
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

       [SerializationOrder(1)]
       public TVector<IContactBlocked> Blocked {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
