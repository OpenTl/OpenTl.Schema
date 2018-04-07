// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbcd51581)]
    public sealed class RequestSignIn : IRequest<OpenTl.Schema.Auth.IAuthorization>
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

       /// <summary>Binary representation for the 'PhoneCode' property</summary>
       [SerializationOrder(2)]
       public byte[] PhoneCodeAsBinary { get => _PhoneCodeAsBinary; set { _PhoneCode = Encoding.UTF8.GetString(value); _PhoneCodeAsBinary = value; }}
       private byte[] _PhoneCodeAsBinary;
       private string _PhoneCode;
       public string PhoneCode { get => _PhoneCode; set { PhoneCodeAsBinary = Encoding.UTF8.GetBytes(value); _PhoneCode = value; }}

    }
}
