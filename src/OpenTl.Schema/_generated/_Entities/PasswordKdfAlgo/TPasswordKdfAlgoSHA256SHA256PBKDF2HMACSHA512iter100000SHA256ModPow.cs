// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3a912d4a)]
	public sealed class TPasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow : IPasswordKdfAlgo
	{
       [SerializationOrder(0)]
       public byte[] Salt1 {get; set;}

       [SerializationOrder(1)]
       public byte[] Salt2 {get; set;}

       [SerializationOrder(2)]
       public int G {get; set;}

       [SerializationOrder(3)]
       public byte[] P {get; set;}

	}
}
