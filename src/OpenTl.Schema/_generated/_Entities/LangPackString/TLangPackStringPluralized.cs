// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6c47ac9f)]
	public class TLangPackStringPluralized : ILangPackString
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string Key {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public string ZeroValue {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public string OneValue {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public string TwoValue {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public string FewValue {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public string ManyValue {get; set;}

       [SerializationOrder(7)]
       public string OtherValue {get; set;}

	}
}
