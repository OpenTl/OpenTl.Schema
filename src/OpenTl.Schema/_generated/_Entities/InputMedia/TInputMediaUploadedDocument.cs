// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe39621fd)]
	public class TInputMediaUploadedDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputFile File {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public IInputFile Thumb {get; set;}

       [SerializationOrder(3)]
       public string MimeType {get; set;}

       [SerializationOrder(4)]
       public TVector<IDocumentAttribute> Attributes {get; set;}

       [SerializationOrder(5)]
       public string Caption {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public TVector<IInputDocument> Stickers {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public int TtlSeconds {get; set;}

	}
}
