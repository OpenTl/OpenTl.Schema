// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfdb19008)]
	public sealed class TMessageMediaGame : IMessageMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IGame Game {get; set;}

	}
}
