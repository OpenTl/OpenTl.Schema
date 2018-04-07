// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8317c0c3)]
	public sealed class TUpdateBotWebhookJSON : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IDataJSON Data {get; set;}

	}
}
