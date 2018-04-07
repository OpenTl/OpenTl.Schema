// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xea02c27e)]
	public sealed class TPaymentCharge : IPaymentCharge
	{
       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(0)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       /// <summary>Binary representation for the 'ProviderChargeId' property</summary>
       [SerializationOrder(1)]
       public byte[] ProviderChargeIdAsBinary { get => _ProviderChargeIdAsBinary; set { _ProviderChargeId = Encoding.UTF8.GetString(value); _ProviderChargeIdAsBinary = value; }}
       private byte[] _ProviderChargeIdAsBinary;
       private string _ProviderChargeId;
       public string ProviderChargeId { get => _ProviderChargeId; set { ProviderChargeIdAsBinary = Encoding.UTF8.GetBytes(value); _ProviderChargeId = value; }}

	}
}
