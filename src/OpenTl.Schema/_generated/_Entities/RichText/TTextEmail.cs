// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xde5a0dd6)]
	public sealed class TTextEmail : IRichText
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

       /// <summary>Binary representation for the 'Email' property</summary>
       [SerializationOrder(1)]
       public byte[] EmailAsBinary { get => _EmailAsBinary; set { _Email = Encoding.UTF8.GetString(value); _EmailAsBinary = value; }}
       private byte[] _EmailAsBinary;
       private string _Email;
       public string Email { get => _Email; set { EmailAsBinary = Encoding.UTF8.GetBytes(value); _Email = value; }}

	}
}
