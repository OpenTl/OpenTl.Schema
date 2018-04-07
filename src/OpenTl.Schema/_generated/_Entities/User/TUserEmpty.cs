// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x200250ba)]
	public sealed class TUserEmpty : IUser, IEmpty
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
