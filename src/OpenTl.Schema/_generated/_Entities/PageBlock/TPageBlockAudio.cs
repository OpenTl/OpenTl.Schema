// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x31b81a7f)]
	public class TPageBlockAudio : IPageBlock
	{
       [SerializationOrder(0)]
       public long AudioId {get; set;}

       [SerializationOrder(1)]
       public IRichText Caption {get; set;}

	}
}
