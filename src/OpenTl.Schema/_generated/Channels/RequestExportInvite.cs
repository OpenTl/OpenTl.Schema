namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7560885)]
    public class RequestExportInvite : IRequest<IExportedChatInvite>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

    }
}
