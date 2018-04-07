// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x450a1c0a)]
	public sealed class TFoundGifs : IFoundGifs
	{
       [SerializationOrder(0)]
       public int NextOffset {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IFoundGif> Results {get; set;}

	}
}
