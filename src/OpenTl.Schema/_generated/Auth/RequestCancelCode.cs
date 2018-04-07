// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1f040578)]
    public sealed class RequestCancelCode : IRequest<bool>
    {
       /// <summary>Binary representation for the 'PhoneNumber' property</summary>
       [SerializationOrder(0)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

       /// <summary>Binary representation for the 'PhoneCodeHash' property</summary>
       [SerializationOrder(1)]
       public byte[] PhoneCodeHashAsBinary { get => _PhoneCodeHashAsBinary; set { _PhoneCodeHash = Encoding.UTF8.GetString(value); _PhoneCodeHashAsBinary = value; }}
       private byte[] _PhoneCodeHashAsBinary;
       private string _PhoneCodeHash;
       public string PhoneCodeHash { get => _PhoneCodeHash; set { PhoneCodeHashAsBinary = Encoding.UTF8.GetBytes(value); _PhoneCodeHash = value; }}

    }
}
