// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x56e0d474)]
	public sealed class TMessageMediaGeo : IMessageMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

	}
}
