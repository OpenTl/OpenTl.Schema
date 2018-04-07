// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xffe6ab67)]
	public sealed class TPhoneCall : IPhoneCall
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       public int AdminId {get; set;}

       [SerializationOrder(4)]
       public int ParticipantId {get; set;}

       [SerializationOrder(5)]
       public byte[] GAOrB {get; set;}

       [SerializationOrder(6)]
       public long KeyFingerprint {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IPhoneConnection Connection {get; set;}

       [SerializationOrder(9)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPhoneConnection> AlternativeConnections {get; set;}

       [SerializationOrder(10)]
       public int StartDate {get; set;}

	}
}
