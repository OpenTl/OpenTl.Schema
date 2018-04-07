// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf5045f1f)]
    public sealed class RequestSetClientDHParams : IRequest<OpenTl.Schema.ISetClientDHParamsAnswer>
    {
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       /// <summary>Binary representation for the 'EncryptedData' property</summary>
       [SerializationOrder(2)]
       public byte[] EncryptedDataAsBinary { get => _EncryptedDataAsBinary; set { _EncryptedData = Encoding.UTF8.GetString(value); _EncryptedDataAsBinary = value; }}
       private byte[] _EncryptedDataAsBinary;
       private string _EncryptedData;
       public string EncryptedData { get => _EncryptedData; set { EncryptedDataAsBinary = Encoding.UTF8.GetBytes(value); _EncryptedData = value; }}

    }
}
