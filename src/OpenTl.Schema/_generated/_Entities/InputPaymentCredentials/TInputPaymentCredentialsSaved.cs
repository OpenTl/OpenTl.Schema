// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc10eb2cf)]
	public sealed class TInputPaymentCredentialsSaved : IInputPaymentCredentials
	{
       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(0)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       [SerializationOrder(1)]
       public byte[] TmpPassword {get; set;}

	}
}
