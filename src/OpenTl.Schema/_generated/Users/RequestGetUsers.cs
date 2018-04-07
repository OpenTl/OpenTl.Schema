// ReSharper disable All

namespace OpenTl.Schema.Users
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd91a548)]
    public sealed class RequestGetUsers : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IUser>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputUser> Id {get; set;}

    }
}
