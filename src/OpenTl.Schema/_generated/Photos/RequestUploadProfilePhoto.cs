// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4f32c098)]
    public class RequestUploadProfilePhoto : IRequest<Photos.IPhoto>
    {
       [SerializationOrder(0)]
       public IInputFile File {get; set;}

    }
}
