// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1527bcac)]
	public sealed class TSecureSecretSettings : ISecureSecretSettings
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ISecurePasswordKdfAlgo SecureAlgo {get; set;}

       [SerializationOrder(1)]
       public byte[] SecureSecret {get; set;}

       [SerializationOrder(2)]
       public long SecureSecretId {get; set;}

	}
}
