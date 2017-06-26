// ReSharper disable All

namespace OpenTl.Schema.Users
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd91a548)]
    public class RequestGetUsers : IRequest<TVector<IUser>>
    {
       [SerializationOrder(0)]
       public TVector<IInputUser> Id {get; set;}

    }
}
