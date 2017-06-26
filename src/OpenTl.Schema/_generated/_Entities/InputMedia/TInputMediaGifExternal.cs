// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4843b0fd)]
	public class TInputMediaGifExternal : IInputMedia
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public string Q {get; set;}

	}
}
