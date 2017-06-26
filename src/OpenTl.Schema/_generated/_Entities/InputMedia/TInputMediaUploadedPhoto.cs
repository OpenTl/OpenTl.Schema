// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x630c9af1)]
	public class TInputMediaUploadedPhoto : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputFile File {get; set;}

       [SerializationOrder(2)]
       public string Caption {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public TVector<IInputDocument> Stickers {get; set;}

	}
}
