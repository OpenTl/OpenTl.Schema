// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x92153685)]
	public class TInputMediaInvoice : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

       [SerializationOrder(2)]
       public string Description {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public IInputWebDocument Photo {get; set;}

       [SerializationOrder(4)]
       public IInvoice Invoice {get; set;}

       [SerializationOrder(5)]
       public byte[] Payload {get; set;}

       [SerializationOrder(6)]
       public string Provider {get; set;}

       [SerializationOrder(7)]
       public string StartParam {get; set;}

	}
}
