// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xed1ecdb0)]
	public sealed class TSecureValueHash : ISecureValueHash
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ISecureValueType Type {get; set;}

       [SerializationOrder(1)]
       public byte[] Hash {get; set;}

	}
}
