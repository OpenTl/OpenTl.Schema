// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x500911e1)]
	public sealed class TPaymentReceipt : IPaymentReceipt
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

       [SerializationOrder(2)]
       public int BotId {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInvoice Invoice {get; set;}

       [SerializationOrder(4)]
       public int ProviderId {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPaymentRequestedInfo Info {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IShippingOption Shipping {get; set;}

       /// <summary>Binary representation for the 'Currency' property</summary>
       [SerializationOrder(7)]
       public byte[] CurrencyAsBinary { get => _CurrencyAsBinary; set { _Currency = Encoding.UTF8.GetString(value); _CurrencyAsBinary = value; }}
       private byte[] _CurrencyAsBinary;
       private string _Currency;
       public string Currency { get => _Currency; set { CurrencyAsBinary = Encoding.UTF8.GetBytes(value); _Currency = value; }}

       [SerializationOrder(8)]
       public long TotalAmount {get; set;}

       /// <summary>Binary representation for the 'CredentialsTitle' property</summary>
       [SerializationOrder(9)]
       public byte[] CredentialsTitleAsBinary { get => _CredentialsTitleAsBinary; set { _CredentialsTitle = Encoding.UTF8.GetString(value); _CredentialsTitleAsBinary = value; }}
       private byte[] _CredentialsTitleAsBinary;
       private string _CredentialsTitle;
       public string CredentialsTitle { get => _CredentialsTitle; set { CredentialsTitleAsBinary = Encoding.UTF8.GetBytes(value); _CredentialsTitle = value; }}

       [SerializationOrder(10)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
