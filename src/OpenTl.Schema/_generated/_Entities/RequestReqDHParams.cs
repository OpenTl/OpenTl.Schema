// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd712e4be)]
    public class RequestReqDHParams : IRequest<IServerDHParams>
    {
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationOrder(2)]
       public byte[] PAsBinary { get => _PAsBinary; set { _P = Encoding.UTF8.GetString(value); _PAsBinary = value; }}
       private byte[] _PAsBinary;
       private string _P;
       public string P { get => _P; set { PAsBinary = Encoding.UTF8.GetBytes(value); _P = value; }}

       [SerializationOrder(3)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(4)]
       public long PublicKeyFingerprint {get; set;}

       [SerializationOrder(5)]
       public byte[] EncryptedDataAsBinary { get => _EncryptedDataAsBinary; set { _EncryptedData = Encoding.UTF8.GetString(value); _EncryptedDataAsBinary = value; }}
       private byte[] _EncryptedDataAsBinary;
       private string _EncryptedData;
       public string EncryptedData { get => _EncryptedData; set { EncryptedDataAsBinary = Encoding.UTF8.GetBytes(value); _EncryptedData = value; }}

    }
}
