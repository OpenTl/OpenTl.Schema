// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbbf2dda0)]
	public sealed class TSecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 : ISecurePasswordKdfAlgo
	{
       [SerializationOrder(0)]
       public byte[] Salt {get; set;}

	}
}
