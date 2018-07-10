// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe09e1fb8)]
	public sealed class TProxyDataEmpty : IProxyData, IEmpty
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

	}
}
