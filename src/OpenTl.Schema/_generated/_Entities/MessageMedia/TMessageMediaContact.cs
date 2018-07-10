// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcbf24940)]
	public sealed class TMessageMediaContact : IMessageMedia
	{
       /// <summary>Binary representation for the 'PhoneNumber' property</summary>
       [SerializationOrder(0)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

       /// <summary>Binary representation for the 'FirstName' property</summary>
       [SerializationOrder(1)]
       public byte[] FirstNameAsBinary { get => _FirstNameAsBinary; set { _FirstName = Encoding.UTF8.GetString(value); _FirstNameAsBinary = value; }}
       private byte[] _FirstNameAsBinary;
       private string _FirstName;
       public string FirstName { get => _FirstName; set { FirstNameAsBinary = Encoding.UTF8.GetBytes(value); _FirstName = value; }}

       /// <summary>Binary representation for the 'LastName' property</summary>
       [SerializationOrder(2)]
       public byte[] LastNameAsBinary { get => _LastNameAsBinary; set { _LastName = Encoding.UTF8.GetString(value); _LastNameAsBinary = value; }}
       private byte[] _LastNameAsBinary;
       private string _LastName;
       public string LastName { get => _LastName; set { LastNameAsBinary = Encoding.UTF8.GetBytes(value); _LastName = value; }}

       /// <summary>Binary representation for the 'Vcard' property</summary>
       [SerializationOrder(3)]
       public byte[] VcardAsBinary { get => _VcardAsBinary; set { _Vcard = Encoding.UTF8.GetString(value); _VcardAsBinary = value; }}
       private byte[] _VcardAsBinary;
       private string _Vcard;
       public string Vcard { get => _Vcard; set { VcardAsBinary = Encoding.UTF8.GetBytes(value); _Vcard = value; }}

       [SerializationOrder(4)]
       public int UserId {get; set;}

	}
}
