// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8953ad37)]
	public class TInputChatPhoto : IInputChatPhoto
	{
       [SerializationOrder(0)]
       public IInputPhoto Id {get; set;}

	}
}
