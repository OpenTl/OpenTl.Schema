// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd0e8075c)]
	public sealed class TServerDHParamsOk : IServerDHParams
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       /// <summary>Binary representation for the 'EncryptedAnswer' property</summary>
       [SerializationOrder(2)]
       public byte[] EncryptedAnswerAsBinary { get => _EncryptedAnswerAsBinary; set { _EncryptedAnswer = Encoding.UTF8.GetString(value); _EncryptedAnswerAsBinary = value; }}
       private byte[] _EncryptedAnswerAsBinary;
       private string _EncryptedAnswer;
       public string EncryptedAnswer { get => _EncryptedAnswer; set { EncryptedAnswerAsBinary = Encoding.UTF8.GetBytes(value); _EncryptedAnswer = value; }}

	}
}
