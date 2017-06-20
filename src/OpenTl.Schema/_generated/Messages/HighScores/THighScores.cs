namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a3bfd99)]
	public class THighScores : IHighScores
	{
       [SerializationOrder(0)]
       public TVector<IHighScore> Scores {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
