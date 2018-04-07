// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5ce14175)]
	public sealed class TPopularContact : IPopularContact
	{
       [SerializationOrder(0)]
       public long ClientId {get; set;}

       [SerializationOrder(1)]
       public int Importers {get; set;}

	}
}
