// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x28ecf961)]
	public sealed class TTermsOfServiceUpdate : ITermsOfServiceUpdate
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.Help.ITermsOfService TermsOfService {get; set;}

	}
}
