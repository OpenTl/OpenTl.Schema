namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x87cf7f2f)]
    public class RequestDeletePhotos : IRequest<TVector<long>>
    {
       [SerializationOrder(0)]
       public TVector<IInputPhoto> Id {get; set;}

    }
}
