// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c138d15)]
	public class TBlocked : IBlocked
	{
       [SerializationOrder(0)]
       public TVector<IContactBlocked> Blocked {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
