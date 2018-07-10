// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7bd9c3f1)]
	public sealed class TPasswordSettings : IPasswordSettings
	{
       /// <summary>Binary representation for the 'Email' property</summary>
       [SerializationOrder(0)]
       public byte[] EmailAsBinary { get => _EmailAsBinary; set { _Email = Encoding.UTF8.GetString(value); _EmailAsBinary = value; }}
       private byte[] _EmailAsBinary;
       private string _Email;
       public string Email { get => _Email; set { EmailAsBinary = Encoding.UTF8.GetBytes(value); _Email = value; }}

       [SerializationOrder(1)]
       public byte[] SecureSalt {get; set;}

       [SerializationOrder(2)]
       public byte[] SecureSecret {get; set;}

       [SerializationOrder(3)]
       public long SecureSecretId {get; set;}

	}
}
