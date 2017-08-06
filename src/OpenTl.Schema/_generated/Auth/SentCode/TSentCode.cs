// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5e002502)]
	public class TSentCode : ISentCode
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool PhoneRegistered {get; set;}

       [SerializationOrder(2)]
       public Auth.ISentCodeType Type {get; set;}

       [SerializationOrder(3)]
       public byte[] PhoneCodeHashAsBinary { get => _PhoneCodeHashAsBinary; set { _PhoneCodeHash = Encoding.UTF8.GetString(value); _PhoneCodeHashAsBinary = value; }}
       private byte[] _PhoneCodeHashAsBinary;
       private string _PhoneCodeHash;
       public string PhoneCodeHash { get => _PhoneCodeHash; set { PhoneCodeHashAsBinary = Encoding.UTF8.GetBytes(value); _PhoneCodeHash = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public Auth.ICodeType NextType {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public int Timeout {get; set;}

	}
}
