// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa56c2a3e)]
	public sealed class TState : IState
	{
       [SerializationOrder(0)]
       public int Pts {get; set;}

       [SerializationOrder(1)]
       public int Qts {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       public int Seq {get; set;}

       [SerializationOrder(4)]
       public int UnreadCount {get; set;}

	}
}
