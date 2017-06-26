// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86916deb)]
	public class TPasswordInputSettings : IPasswordInputSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] NewSalt {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] NewPasswordHash {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public string Hint {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public string Email {get; set;}

	}
}
