// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x33ddf480)]
    public sealed class RequestGetAdminLog : IRequest<OpenTl.Schema.Channels.IAdminLogResults>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(2)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IChannelAdminLogEventsFilter EventsFilter {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputUser> Admins {get; set;}

       [SerializationOrder(5)]
       public long MaxId {get; set;}

       [SerializationOrder(6)]
       public long MinId {get; set;}

       [SerializationOrder(7)]
       public int Limit {get; set;}

    }
}
