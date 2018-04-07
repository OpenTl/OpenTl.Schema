// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x91cd32a8)]
    public sealed class RequestGetUserPhotos : IRequest<OpenTl.Schema.Photos.IPhotos>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

       [SerializationOrder(2)]
       public long MaxId {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

    }
}
