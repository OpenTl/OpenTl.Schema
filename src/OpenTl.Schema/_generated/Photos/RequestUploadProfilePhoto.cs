// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4f32c098)]
    public sealed class RequestUploadProfilePhoto : IRequest<OpenTl.Schema.Photos.IPhoto>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputFile File {get; set;}

    }
}
