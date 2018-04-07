// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xca05d50e)]
	public sealed class TInputPaymentCredentialsAndroidPay : IInputPaymentCredentials
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IDataJSON PaymentToken {get; set;}

       /// <summary>Binary representation for the 'GoogleTransactionId' property</summary>
       [SerializationOrder(1)]
       public byte[] GoogleTransactionIdAsBinary { get => _GoogleTransactionIdAsBinary; set { _GoogleTransactionId = Encoding.UTF8.GetString(value); _GoogleTransactionIdAsBinary = value; }}
       private byte[] _GoogleTransactionIdAsBinary;
       private string _GoogleTransactionId;
       public string GoogleTransactionId { get => _GoogleTransactionId; set { GoogleTransactionIdAsBinary = Encoding.UTF8.GetBytes(value); _GoogleTransactionId = value; }}

	}
}
