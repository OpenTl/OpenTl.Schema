// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3309f7f)]
	public sealed class TTermsOfServiceUpdateEmpty : ITermsOfServiceUpdate, IEmpty
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

	}
}
