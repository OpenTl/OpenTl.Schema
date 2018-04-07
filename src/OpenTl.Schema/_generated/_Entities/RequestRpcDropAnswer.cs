// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x58e4a740)]
    public sealed class RequestRpcDropAnswer : IRequest<OpenTl.Schema.IRpcDropAnswer>
    {
       [SerializationOrder(0)]
       public long ReqMsgId {get; set;}

    }
}
