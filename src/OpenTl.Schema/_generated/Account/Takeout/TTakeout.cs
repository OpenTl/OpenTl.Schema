// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4dba4501)]
	public sealed class TTakeout : ITakeout
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
