// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x40699cd0)]
	public sealed class TMessageActionPaymentSent : IMessageAction
	{
       /// <summary>Binary representation for the 'Currency' property</summary>
       [SerializationOrder(0)]
       public byte[] CurrencyAsBinary { get => _CurrencyAsBinary; set { _Currency = Encoding.UTF8.GetString(value); _CurrencyAsBinary = value; }}
       private byte[] _CurrencyAsBinary;
       private string _Currency;
       public string Currency { get => _Currency; set { CurrencyAsBinary = Encoding.UTF8.GetBytes(value); _Currency = value; }}

       [SerializationOrder(1)]
       public long TotalAmount {get; set;}

	}
}
