// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xee8c1e86)]
	public sealed class TInputChannelEmpty : IInputChannel, IEmpty
	{

	}
}
