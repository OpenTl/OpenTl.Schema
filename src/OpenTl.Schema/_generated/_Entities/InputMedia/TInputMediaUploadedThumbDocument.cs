namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x50d88cae)]
	public class TInputMediaUploadedThumbDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputFile File {get; set;}

       [SerializationOrder(2)]
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

	}
}
