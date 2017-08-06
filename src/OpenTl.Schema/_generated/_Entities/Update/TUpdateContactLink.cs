// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9d2e67c5)]
	public class TUpdateContactLink : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public IContactLink MyLink {get; set;}

       [SerializationOrder(2)]
       public IContactLink ForeignLink {get; set;}

	}
}
