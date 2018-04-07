// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xec82e140)]
	public sealed class TPhoneCall : IPhoneCall
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPhoneCall PhoneCall {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
