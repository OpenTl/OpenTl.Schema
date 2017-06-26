// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x38935eb2)]
	public class TInputPeerNotifySettings : IInputPeerNotifySettings
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
