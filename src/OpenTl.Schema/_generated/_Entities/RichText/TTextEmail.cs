// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xde5a0dd6)]
	public class TTextEmail : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

       [SerializationOrder(1)]
       public string Email {get; set;}

	}
}
