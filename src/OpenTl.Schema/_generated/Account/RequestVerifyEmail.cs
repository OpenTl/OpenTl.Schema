// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xecba39db)]
    public sealed class RequestVerifyEmail : IRequest<bool>
    {
       /// <summary>Binary representation for the 'Email' property</summary>
       [SerializationOrder(0)]
       public byte[] EmailAsBinary { get => _EmailAsBinary; set { _Email = Encoding.UTF8.GetString(value); _EmailAsBinary = value; }}
       private byte[] _EmailAsBinary;
       private string _Email;
       public string Email { get => _Email; set { EmailAsBinary = Encoding.UTF8.GetBytes(value); _Email = value; }}

       /// <summary>Binary representation for the 'Code' property</summary>
       [SerializationOrder(1)]
       public byte[] CodeAsBinary { get => _CodeAsBinary; set { _Code = Encoding.UTF8.GetString(value); _CodeAsBinary = value; }}
       private byte[] _CodeAsBinary;
       private string _Code;
       public string Code { get => _Code; set { CodeAsBinary = Encoding.UTF8.GetBytes(value); _Code = value; }}

    }
}
