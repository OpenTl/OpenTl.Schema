// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8987f311)]
	public class TAppUpdate : IAppUpdate
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public bool Critical {get; set;}

       [SerializationOrder(2)]
       public string Url {get; set;}

       [SerializationOrder(3)]
       public string Text {get; set;}

	}
}
