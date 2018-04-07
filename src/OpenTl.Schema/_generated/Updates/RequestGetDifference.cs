// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x25939651)]
    public sealed class RequestGetDifference : IRequest<OpenTl.Schema.Updates.IDifference>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int PtsTotalLimit {get; set;}

       [SerializationOrder(3)]
       public int Date {get; set;}

       [SerializationOrder(4)]
       public int Qts {get; set;}

    }
}
