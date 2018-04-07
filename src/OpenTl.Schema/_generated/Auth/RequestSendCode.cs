// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86aef0ec)]
    public sealed class RequestSendCode : IRequest<OpenTl.Schema.Auth.ISentCode>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool AllowFlashcall {get; set;}

       /// <summary>Binary representation for the 'PhoneNumber' property</summary>
       [SerializationOrder(2)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public bool CurrentNumber {get; set;}

       [SerializationOrder(4)]
       public int ApiId {get; set;}

       /// <summary>Binary representation for the 'ApiHash' property</summary>
       [SerializationOrder(5)]
       public byte[] ApiHashAsBinary { get => _ApiHashAsBinary; set { _ApiHash = Encoding.UTF8.GetString(value); _ApiHashAsBinary = value; }}
       private byte[] _ApiHashAsBinary;
       private string _ApiHash;
       public string ApiHash { get => _ApiHash; set { ApiHashAsBinary = Encoding.UTF8.GetBytes(value); _ApiHash = value; }}

    }
}
