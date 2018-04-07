// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3ded6320)]
	public sealed class TMessageMediaEmpty : IMessageMedia, IEmpty
	{

	}
}
