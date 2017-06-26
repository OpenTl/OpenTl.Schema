// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e0709a5)]
	public class TSavedGifs : ISavedGifs
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public TVector<IDocument> Gifs {get; set;}

	}
}
