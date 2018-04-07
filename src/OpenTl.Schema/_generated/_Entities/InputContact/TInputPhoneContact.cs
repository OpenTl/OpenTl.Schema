// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf392b7f4)]
	public sealed class TInputPhoneContact : IInputContact
	{
       [SerializationOrder(0)]
       public long ClientId {get; set;}

       /// <summary>Binary representation for the 'Phone' property</summary>
       [SerializationOrder(1)]
       public byte[] PhoneAsBinary { get => _PhoneAsBinary; set { _Phone = Encoding.UTF8.GetString(value); _PhoneAsBinary = value; }}
       private byte[] _PhoneAsBinary;
       private string _Phone;
       public string Phone { get => _Phone; set { PhoneAsBinary = Encoding.UTF8.GetBytes(value); _Phone = value; }}

       /// <summary>Binary representation for the 'FirstName' property</summary>
       [SerializationOrder(2)]
       public byte[] FirstNameAsBinary { get => _FirstNameAsBinary; set { _FirstName = Encoding.UTF8.GetString(value); _FirstNameAsBinary = value; }}
       private byte[] _FirstNameAsBinary;
       private string _FirstName;
       public string FirstName { get => _FirstName; set { FirstNameAsBinary = Encoding.UTF8.GetBytes(value); _FirstName = value; }}

       /// <summary>Binary representation for the 'LastName' property</summary>
       [SerializationOrder(3)]
       public byte[] LastNameAsBinary { get => _LastNameAsBinary; set { _LastName = Encoding.UTF8.GetString(value); _LastNameAsBinary = value; }}
       private byte[] _LastNameAsBinary;
       private string _LastName;
       public string LastName { get => _LastName; set { LastNameAsBinary = Encoding.UTF8.GetBytes(value); _LastName = value; }}

	}
}
