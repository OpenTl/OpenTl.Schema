// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2714d86c)]
    public sealed class RequestCheckUsername : IRequest<bool>
    {
       /// <summary>Binary representation for the 'Username' property</summary>
       [SerializationOrder(0)]
       public byte[] UsernameAsBinary { get => _UsernameAsBinary; set { _Username = Encoding.UTF8.GetString(value); _UsernameAsBinary = value; }}
       private byte[] _UsernameAsBinary;
       private string _Username;
       public string Username { get => _Username; set { UsernameAsBinary = Encoding.UTF8.GetBytes(value); _Username = value; }}

    }
}
