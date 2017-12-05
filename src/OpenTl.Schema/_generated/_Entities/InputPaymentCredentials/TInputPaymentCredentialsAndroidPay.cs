// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x795667a6)]
	public class TInputPaymentCredentialsAndroidPay : IInputPaymentCredentials
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IDataJSON PaymentToken {get; set;}

	}
}
