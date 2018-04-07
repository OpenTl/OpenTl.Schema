// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd1451883)]
	public sealed class TValidatedRequestedInfo : IValidatedRequestedInfo
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IShippingOption> ShippingOptions {get; set;}

	}
}
