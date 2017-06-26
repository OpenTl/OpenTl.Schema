// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf0bb5152)]
    public class RequestUpdateProfilePhoto : IRequest<IUserProfilePhoto>
    {
       [SerializationOrder(0)]
       public IInputPhoto Id {get; set;}

    }
}
