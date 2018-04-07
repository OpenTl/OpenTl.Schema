// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x69df3769)]
	public sealed class TChatInviteEmpty : IExportedChatInvite, IEmpty
	{

	}
}
