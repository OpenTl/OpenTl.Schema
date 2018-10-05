// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x187fa0ca)]
	public sealed class TSecureValue : ISecureValue
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.ISecureValueType Type {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.ISecureData Data {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.ISecureFile FrontSide {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.ISecureFile ReverseSide {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.ISecureFile Selfie {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureFile> Translation {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureFile> Files {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 5)]
       public OpenTl.Schema.ISecurePlainData PlainData {get; set;}

       [SerializationOrder(9)]
       public byte[] Hash {get; set;}

	}
}
