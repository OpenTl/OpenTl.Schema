// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x829d99da)]
	public sealed class TSecureRequiredType : ISecureRequiredType
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool NativeNames {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool SelfieRequired {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool TranslationRequired {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.ISecureValueType Type {get; set;}

	}
}
