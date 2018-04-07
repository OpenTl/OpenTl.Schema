// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x418d4e0b)]
    public sealed class RequestDeleteAccount : IRequest<bool>
    {
       /// <summary>Binary representation for the 'Reason' property</summary>
       [SerializationOrder(0)]
       public byte[] ReasonAsBinary { get => _ReasonAsBinary; set { _Reason = Encoding.UTF8.GetString(value); _ReasonAsBinary = value; }}
       private byte[] _ReasonAsBinary;
       private string _Reason;
       public string Reason { get => _Reason; set { ReasonAsBinary = Encoding.UTF8.GetBytes(value); _Reason = value; }}

    }
}
