// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd33f43f3)]
	public class TInputMediaGame : IInputMedia
	{
       [SerializationOrder(0)]
       public IInputGame Id {get; set;}

	}
}
