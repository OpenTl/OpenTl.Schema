// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x12b9417b)]
	public sealed class TUpdateUserPhone : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       /// <summary>Binary representation for the 'Phone' property</summary>
       [SerializationOrder(1)]
       public byte[] PhoneAsBinary { get => _PhoneAsBinary; set { _Phone = Encoding.UTF8.GetString(value); _PhoneAsBinary = value; }}
       private byte[] _PhoneAsBinary;
       private string _Phone;
       public string Phone { get => _Phone; set { PhoneAsBinary = Encoding.UTF8.GetBytes(value); _Phone = value; }}

	}
}
