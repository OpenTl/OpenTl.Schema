// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa098d6af)]
	public sealed class TPassportConfig : IPassportConfig
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IDataJSON CountriesLangs {get; set;}

	}
}
