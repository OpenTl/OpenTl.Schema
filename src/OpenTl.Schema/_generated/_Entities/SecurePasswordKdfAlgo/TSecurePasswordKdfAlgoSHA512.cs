// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86471d92)]
	public sealed class TSecurePasswordKdfAlgoSHA512 : ISecurePasswordKdfAlgo
	{
       [SerializationOrder(0)]
       public byte[] Salt {get; set;}

	}
}
