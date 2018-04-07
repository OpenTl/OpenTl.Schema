// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf0bb5152)]
    public sealed class RequestUpdateProfilePhoto : IRequest<OpenTl.Schema.IUserProfilePhoto>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPhoto Id {get; set;}

    }
}
