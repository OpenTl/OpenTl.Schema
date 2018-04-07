// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x38fe25b7)]
	public sealed class TUpdateEncryptedMessagesRead : IUpdate
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public int MaxDate {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
