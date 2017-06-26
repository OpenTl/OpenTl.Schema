// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x770656a8)]
	public class TInputAppEvent : IInputAppEvent
	{
       [SerializationOrder(0)]
       public double Ime {get; set;}

       [SerializationOrder(1)]
       public string Type {get; set;}

       [SerializationOrder(2)]
       public long Peer {get; set;}

       [SerializationOrder(3)]
       public string Data {get; set;}

	}
}
