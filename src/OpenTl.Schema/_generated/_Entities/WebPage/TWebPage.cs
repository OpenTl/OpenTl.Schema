namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5f07b4bc)]
	public class TWebPage : IWebPage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long Id {get; set;}

       [SerializationOrder(2)]
       public string Url {get; set;}

       [SerializationOrder(3)]
       public string DisplayUrl {get; set;}

       [SerializationOrder(4)]
       public int Hash {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public string Type {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public string SiteName {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public string Title {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 3)]
       public string Description {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 4)]
       public IPhoto Photo {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 5)]
       public string EmbedUrl {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 5)]
       public string EmbedType {get; set;}

       [SerializationOrder(12)]
       [CanSerialize("Flags", 6)]
       public int EmbedWidth {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 6)]
       public int EmbedHeight {get; set;}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 7)]
       public int Duration {get; set;}

       [SerializationOrder(15)]
       [CanSerialize("Flags", 8)]
       public string Author {get; set;}

       [SerializationOrder(16)]
       [CanSerialize("Flags", 9)]
       public IDocument Document {get; set;}

       [SerializationOrder(17)]
       [CanSerialize("Flags", 10)]
       public IPage CachedPage {get; set;}

	}
}
