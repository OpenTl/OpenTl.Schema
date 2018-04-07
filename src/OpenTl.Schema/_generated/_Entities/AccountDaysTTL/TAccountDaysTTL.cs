// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb8d0afdf)]
	public sealed class TAccountDaysTTL : IAccountDaysTTL
	{
       [SerializationOrder(0)]
       public int Days {get; set;}

	}
}
