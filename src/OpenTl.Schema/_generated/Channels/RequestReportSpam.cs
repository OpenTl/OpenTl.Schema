// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfe087810)]
    public sealed class RequestReportSpam : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

    }
}
