// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x909c3f94)]
	public sealed class TPaymentRequestedInfo : IPaymentRequestedInfo
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Name' property</summary>
       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

       /// <summary>Binary representation for the 'Phone' property</summary>
       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public byte[] PhoneAsBinary { get => _PhoneAsBinary; set { _Phone = Encoding.UTF8.GetString(value); _PhoneAsBinary = value; }}
       private byte[] _PhoneAsBinary;
       private string _Phone;
       public string Phone { get => _Phone; set { PhoneAsBinary = Encoding.UTF8.GetBytes(value); _Phone = value; }}

       /// <summary>Binary representation for the 'Email' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public byte[] EmailAsBinary { get => _EmailAsBinary; set { _Email = Encoding.UTF8.GetString(value); _EmailAsBinary = value; }}
       private byte[] _EmailAsBinary;
       private string _Email;
       public string Email { get => _Email; set { EmailAsBinary = Encoding.UTF8.GetBytes(value); _Email = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IPostAddress ShippingAddress {get; set;}

	}
}
