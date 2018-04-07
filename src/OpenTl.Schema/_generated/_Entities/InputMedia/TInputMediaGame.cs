// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd33f43f3)]
	public sealed class TInputMediaGame : IInputMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputGame Id {get; set;}

	}
}
