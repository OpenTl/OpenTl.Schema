// ReSharper disable All

namespace OpenTl.Schema.Payments
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentForm : IObject
    {
       BitArray Flags {get; set;}

       bool CanSaveCredentials {get; set;}

       bool PasswordMissing {get; set;}

       int BotId {get; set;}

       OpenTl.Schema.IInvoice Invoice {get; set;}

       int ProviderId {get; set;}

       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       byte[] NativeProviderAsBinary {get; set;}
       string NativeProvider {get; set;}

       OpenTl.Schema.IDataJSON NativeParams {get; set;}

       OpenTl.Schema.IPaymentRequestedInfo SavedInfo {get; set;}

       OpenTl.Schema.IPaymentSavedCredentials SavedCredentials {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
