// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x92a72876)]
	public sealed class TMessageActionGameScore : IMessageAction
	{
       [SerializationOrder(0)]
       public long GameId {get; set;}

       [SerializationOrder(1)]
       public int Score {get; set;}

	}
}
