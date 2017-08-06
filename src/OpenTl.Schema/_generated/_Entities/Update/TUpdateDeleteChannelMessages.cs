// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc37521c9)]
	public class TUpdateDeleteChannelMessages : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public TVector<int> Messages {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       public int PtsCount {get; set;}

	}
}
