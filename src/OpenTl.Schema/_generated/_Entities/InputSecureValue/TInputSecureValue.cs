// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdb21d0a7)]
	public sealed class TInputSecureValue : IInputSecureValue
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
       public OpenTl.Schema.IInputSecureFile FrontSide {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputSecureFile ReverseSide {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IInputSecureFile Selfie {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputSecureFile> Translation {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputSecureFile> Files {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 5)]
       public OpenTl.Schema.ISecurePlainData PlainData {get; set;}

	}
}
