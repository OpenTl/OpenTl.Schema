// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x87cf7f2f)]
    public sealed class RequestDeletePhotos : IRequest<OpenTl.Schema.TVector<long>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputPhoto> Id {get; set;}

    }
}
