// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaa1c39f)]
	public sealed class TInputPaymentCredentialsApplePay : IInputPaymentCredentials
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IDataJSON PaymentData {get; set;}

	}
}
