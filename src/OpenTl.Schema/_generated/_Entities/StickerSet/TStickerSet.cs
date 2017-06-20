namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcd303b41)]
	public class TStickerSet : IStickerSet
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Installed {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Archived {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Official {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool Masks {get; set;}

       [SerializationOrder(5)]
       public long Id {get; set;}

       [SerializationOrder(6)]
       public long AccessHash {get; set;}

       [SerializationOrder(7)]
       public string Title {get; set;}

       [SerializationOrder(8)]
       public string ShortName {get; set;}

       [SerializationOrder(9)]
       public int Count {get; set;}

       [SerializationOrder(10)]
       public int Hash {get; set;}

	}
}
