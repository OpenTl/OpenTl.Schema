// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5a592a6c)]
	public sealed class TConfigSimple : IObject
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

       [SerializationOrder(1)]
       public int Expires {get; set;}

       [SerializationOrder(2)]
       [BareTypeAttribute]
       public TVector<OpenTl.Schema.IAccessPointRule> Rules {get; set;}

	}
}
