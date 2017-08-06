// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xadd53cb3)]
	public class TPeerNotifyEventsEmpty : IPeerNotifyEvents, IEmpty
	{

	}
}
