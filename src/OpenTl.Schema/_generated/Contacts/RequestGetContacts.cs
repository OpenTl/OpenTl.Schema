// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x22c6aa08)]
    public class RequestGetContacts : IRequest<OpenTl.Schema.Contacts.IContacts>
    {
       [SerializationOrder(0)]
       public byte[] HashAsBinary { get => _HashAsBinary; set { _Hash = Encoding.UTF8.GetString(value); _HashAsBinary = value; }}
       private byte[] _HashAsBinary;
       private string _Hash;
       public string Hash { get => _Hash; set { HashAsBinary = Encoding.UTF8.GetBytes(value); _Hash = value; }}

    }
}
