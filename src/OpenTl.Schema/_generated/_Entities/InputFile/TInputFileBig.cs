// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfa4f0bb5)]
	public class TInputFileBig : IInputFile
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public int Parts {get; set;}

       [SerializationOrder(2)]
       public string Name {get; set;}

	}
}
