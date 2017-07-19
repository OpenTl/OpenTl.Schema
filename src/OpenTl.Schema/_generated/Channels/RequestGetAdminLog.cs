// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x33ddf480)]
    public class RequestGetAdminLog : IRequest<Channels.IAdminLogResults>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(2)]
       public string Q {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public IChannelAdminLogEventsFilter EventsFilter {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public TVector<IInputUser> Admins {get; set;}

       [SerializationOrder(5)]
       public long MaxId {get; set;}

       [SerializationOrder(6)]
       public long MinId {get; set;}

       [SerializationOrder(7)]
       public int Limit {get; set;}

    }
}
