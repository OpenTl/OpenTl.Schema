// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x500911e1)]
	public class TPaymentReceipt : IPaymentReceipt
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

       [SerializationOrder(2)]
       public int BotId {get; set;}

       [SerializationOrder(3)]
       public IInvoice Invoice {get; set;}

       [SerializationOrder(4)]
       public int ProviderId {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public IPaymentRequestedInfo Info {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public IShippingOption Shipping {get; set;}

       [SerializationOrder(7)]
       public string Currency {get; set;}

       [SerializationOrder(8)]
       public long TotalAmount {get; set;}

       [SerializationOrder(9)]
       public string CredentialsTitle {get; set;}

       [SerializationOrder(10)]
       public TVector<IUser> Users {get; set;}

	}
}
