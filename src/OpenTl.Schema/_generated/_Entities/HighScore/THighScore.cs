// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x58fffcd0)]
	public sealed class THighScore : IHighScore
	{
       [SerializationOrder(0)]
       public int Pos {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       [SerializationOrder(2)]
       public int Score {get; set;}

	}
}
