// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd997c3c5)]
	public class TConfigSimple : IObject
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

       [SerializationOrder(1)]
       public int Expires {get; set;}

       [SerializationOrder(2)]
       public int DcId {get; set;}

       [SerializationOrder(3)]
       public TVector<TIpPort> IpPortList {get; set;}

	}
}
