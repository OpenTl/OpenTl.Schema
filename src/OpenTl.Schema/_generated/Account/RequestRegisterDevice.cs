// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x637ea878)]
    public class RequestRegisterDevice : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int TokenType {get; set;}

       [SerializationOrder(1)]
       public byte[] TokenAsBinary { get => _TokenAsBinary; set { _Token = Encoding.UTF8.GetString(value); _TokenAsBinary = value; }}
       private byte[] _TokenAsBinary;
       private string _Token;
       public string Token { get => _Token; set { TokenAsBinary = Encoding.UTF8.GetBytes(value); _Token = value; }}

    }
}
