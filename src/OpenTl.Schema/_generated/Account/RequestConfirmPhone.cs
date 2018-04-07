// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5f2178c3)]
    public sealed class RequestConfirmPhone : IRequest<bool>
    {
       /// <summary>Binary representation for the 'PhoneCodeHash' property</summary>
       [SerializationOrder(0)]
       public byte[] PhoneCodeHashAsBinary { get => _PhoneCodeHashAsBinary; set { _PhoneCodeHash = Encoding.UTF8.GetString(value); _PhoneCodeHashAsBinary = value; }}
       private byte[] _PhoneCodeHashAsBinary;
       private string _PhoneCodeHash;
       public string PhoneCodeHash { get => _PhoneCodeHash; set { PhoneCodeHashAsBinary = Encoding.UTF8.GetBytes(value); _PhoneCodeHash = value; }}

       /// <summary>Binary representation for the 'PhoneCode' property</summary>
       [SerializationOrder(1)]
       public byte[] PhoneCodeAsBinary { get => _PhoneCodeAsBinary; set { _PhoneCode = Encoding.UTF8.GetString(value); _PhoneCodeAsBinary = value; }}
       private byte[] _PhoneCodeAsBinary;
       private string _PhoneCode;
       public string PhoneCode { get => _PhoneCode; set { PhoneCodeAsBinary = Encoding.UTF8.GetBytes(value); _PhoneCode = value; }}

    }
}
