// ReSharper disable All

namespace OpenTl.Schema.Users
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xca30a5b1)]
    public sealed class RequestGetFullUser : IRequest<OpenTl.Schema.IUserFull>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser Id {get; set;}

    }
}
