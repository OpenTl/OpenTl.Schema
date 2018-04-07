// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x725b04c3)]
	public sealed class TUpdatesCombined : IUpdates
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUpdate> Updates {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(3)]
       public int Date {get; set;}

       [SerializationOrder(4)]
       public int SeqStart {get; set;}

       [SerializationOrder(5)]
       public int Seq {get; set;}

	}
}
