// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x11f812d8)]
    public sealed class RequestSearch : IRequest<OpenTl.Schema.Contacts.IFound>
    {
       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(0)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(1)]
       public int Limit {get; set;}

    }
}
