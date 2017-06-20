namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9acda4c0)]
	public class TPeerNotifySettings : IPeerNotifySettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ShowPreviews {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Silent {get; set;}

       [SerializationOrder(3)]
       public int MuteUntil {get; set;}

       [SerializationOrder(4)]
       public string Sound {get; set;}

	}
}
