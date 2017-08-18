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

       IInvoice Invoice {get; set;}

       int ProviderId {get; set;}

       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       byte[] NativeProviderAsBinary {get; set;}
       string NativeProvider {get; set;}

       IDataJSON NativeParams {get; set;}

       IPaymentRequestedInfo SavedInfo {get; set;}

       IPaymentSavedCredentials SavedCredentials {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
