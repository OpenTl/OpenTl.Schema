// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3f56aea3)]
	public sealed class TPaymentForm : IPaymentForm
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
       public OpenTl.Schema.IInvoice Invoice {get; set;}

       [SerializationOrder(5)]
       public int ProviderId {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(6)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       /// <summary>Binary representation for the 'NativeProvider' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public byte[] NativeProviderAsBinary { get => _NativeProviderAsBinary; set { _NativeProvider = Encoding.UTF8.GetString(value); _NativeProviderAsBinary = value; }}
       private byte[] _NativeProviderAsBinary;
       private string _NativeProvider;
       public string NativeProvider { get => _NativeProvider; set { NativeProviderAsBinary = Encoding.UTF8.GetBytes(value); _NativeProvider = value; }}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.IDataJSON NativeParams {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPaymentRequestedInfo SavedInfo {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IPaymentSavedCredentials SavedCredentials {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
