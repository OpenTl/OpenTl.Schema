// ReSharper disable All

namespace OpenTl.Schema.Payments
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentReceipt : IObject
    {
       BitArray Flags {get; set;}

       int Date {get; set;}

       int BotId {get; set;}

       IInvoice Invoice {get; set;}

       int ProviderId {get; set;}

       IPaymentRequestedInfo Info {get; set;}

       IShippingOption Shipping {get; set;}

       byte[] CurrencyAsBinary {get; set;}
       string Currency {get; set;}

       long TotalAmount {get; set;}

       byte[] CredentialsTitleAsBinary {get; set;}
       string CredentialsTitle {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
