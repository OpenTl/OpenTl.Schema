// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x22e24e22)]
    public sealed class RequestGetDialogUnreadMarks : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IDialogPeer>>
    {

    }
}
