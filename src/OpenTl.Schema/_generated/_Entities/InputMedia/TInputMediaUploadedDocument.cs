namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd070f1e9)]
	public class TInputMediaUploadedDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputFile File {get; set;}

       [SerializationOrder(2)]
       public string MimeType {get; set;}

       [SerializationOrder(3)]
       public TVector<IDocumentAttribute> Attributes {get; set;}

       [SerializationOrder(4)]
       public string Caption {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public TVector<IInputDocument> Stickers {get; set;}

	}
}
