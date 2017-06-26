// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x12b299d4)]
	public class TStickerPack : IStickerPack
	{
       [SerializationOrder(0)]
       public string Emoticon {get; set;}

       [SerializationOrder(1)]
       public TVector<long> Documents {get; set;}

	}
}
