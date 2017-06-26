// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x78515775)]
    public class RequestUpdateProfile : IRequest<IUser>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public string FirstName {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public string LastName {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public string About {get; set;}

    }
}
