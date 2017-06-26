// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x683a5e46)]
	public class TKeyboardButtonCallback : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(1)]
       public byte[] Data {get; set;}

	}
}
