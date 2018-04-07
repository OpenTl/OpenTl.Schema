// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3ace484c)]
	public sealed class TLink : ILink
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IContactLink MyLink {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IContactLink ForeignLink {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IUser User {get; set;}

	}
}
