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

       OpenTl.Schema.IInvoice Invoice {get; set;}

       int ProviderId {get; set;}

       OpenTl.Schema.IPaymentRequestedInfo Info {get; set;}

       OpenTl.Schema.IShippingOption Shipping {get; set;}

       byte[] CurrencyAsBinary {get; set;}
       string Currency {get; set;}

       long TotalAmount {get; set;}

       byte[] CredentialsTitleAsBinary {get; set;}
       string CredentialsTitle {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
