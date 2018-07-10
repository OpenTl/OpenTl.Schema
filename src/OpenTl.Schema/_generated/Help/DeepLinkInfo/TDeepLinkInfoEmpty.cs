// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x66afa166)]
	public sealed class TDeepLinkInfoEmpty : IDeepLinkInfo, IEmpty
	{

	}
}
