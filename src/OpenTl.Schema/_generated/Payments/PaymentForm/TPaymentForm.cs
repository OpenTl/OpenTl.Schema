namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3f56aea3)]
	public class TPaymentForm : IPaymentForm
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 2)]
       public bool CanSaveCredentials {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool PasswordMissing {get; set;}

       [SerializationOrder(3)]
       public int BotId {get; set;}

       [SerializationOrder(4)]
       public IInvoice Invoice {get; set;}

       [SerializationOrder(5)]
       public int ProviderId {get; set;}

       [SerializationOrder(6)]
       public string Url {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public string NativeProvider {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public IDataJSON NativeParams {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 0)]
       public IPaymentRequestedInfo SavedInfo {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 1)]
       public IPaymentSavedCredentials SavedCredentials {get; set;}

       [SerializationOrder(11)]
       public TVector<IUser> Users {get; set;}

	}
}
