// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7560885)]
    public class RequestExportInvite : IRequest<IExportedChatInvite>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

    }
}
