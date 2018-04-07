// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xba4baec5)]
	public sealed class TDraftMessageEmpty : IDraftMessage, IEmpty
	{

	}
}
