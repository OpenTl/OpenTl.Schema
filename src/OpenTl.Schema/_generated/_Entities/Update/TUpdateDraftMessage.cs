namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xee2bb969)]
	public class TUpdateDraftMessage : IUpdate
	{
       [SerializationOrder(0)]
       public IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public IDraftMessage Draft {get; set;}

	}
}
