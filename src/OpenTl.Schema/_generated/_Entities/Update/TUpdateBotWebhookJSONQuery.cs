// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9b9240a6)]
	public sealed class TUpdateBotWebhookJSONQuery : IUpdate
	{
       [SerializationOrder(0)]
       public long QueryId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IDataJSON Data {get; set;}

       [SerializationOrder(2)]
       public int Timeout {get; set;}

	}
}
