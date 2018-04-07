// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3417d728)]
	public sealed class TInputPaymentCredentials : IInputPaymentCredentials
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Save {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IDataJSON Data {get; set;}

	}
}
