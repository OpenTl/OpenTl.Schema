// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x27477b4)]
	public sealed class TSecureRequiredTypeOneOf : ISecureRequiredType
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureRequiredType> Types {get; set;}

	}
}
