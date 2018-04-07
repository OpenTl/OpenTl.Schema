// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x771c1d97)]
    public sealed class RequestSendInvites : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<string> PhoneNumbers {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(1)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

    }
}
