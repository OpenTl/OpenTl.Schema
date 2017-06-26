// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3ace484c)]
	public class TLink : ILink
	{
       [SerializationOrder(0)]
       public IContactLink MyLink {get; set;}

       [SerializationOrder(1)]
       public IContactLink ForeignLink {get; set;}

       [SerializationOrder(2)]
       public IUser User {get; set;}

	}
}
