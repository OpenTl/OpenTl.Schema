// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xec82e140)]
	public class TPhoneCall : IPhoneCall
	{
       [SerializationOrder(0)]
       public IPhoneCall PhoneCall {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
