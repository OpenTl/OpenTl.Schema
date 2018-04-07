// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8d8d82d7)]
    public sealed class RequestGetAdminedPublicChannels : IRequest<OpenTl.Schema.Messages.IChats>
    {

    }
}
