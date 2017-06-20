namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

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
       public string PhoneCodeHash {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public Auth.ICodeType NextType {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public int Timeout {get; set;}

	}
}
