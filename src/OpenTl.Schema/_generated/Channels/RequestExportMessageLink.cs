// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc846d22d)]
    public class RequestExportMessageLink : IRequest<IExportedMessageLink>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public int Id {get; set;}

    }
}
