// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x438865b)]
	public class TInputStickeredMediaDocument : IInputStickeredMedia
	{
       [SerializationOrder(0)]
       public IInputDocument Id {get; set;}

	}
}
