// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1b067634)]
    public sealed class RequestSignUp : IRequest<OpenTl.Schema.Auth.IAuthorization>
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

       /// <summary>Binary representation for the 'FirstName' property</summary>
       [SerializationOrder(3)]
       public byte[] FirstNameAsBinary { get => _FirstNameAsBinary; set { _FirstName = Encoding.UTF8.GetString(value); _FirstNameAsBinary = value; }}
       private byte[] _FirstNameAsBinary;
       private string _FirstName;
       public string FirstName { get => _FirstName; set { FirstNameAsBinary = Encoding.UTF8.GetBytes(value); _FirstName = value; }}

       /// <summary>Binary representation for the 'LastName' property</summary>
       [SerializationOrder(4)]
       public byte[] LastNameAsBinary { get => _LastNameAsBinary; set { _LastName = Encoding.UTF8.GetString(value); _LastNameAsBinary = value; }}
       private byte[] _LastNameAsBinary;
       private string _LastName;
       public string LastName { get => _LastName; set { LastNameAsBinary = Encoding.UTF8.GetBytes(value); _LastName = value; }}

    }
}
