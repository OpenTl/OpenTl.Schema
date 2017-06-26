// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9852f9c6)]
	public class TDocumentAttributeAudio : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 10)]
       public bool Voice {get; set;}

       [SerializationOrder(2)]
       public int Duration {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public string Title {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public string Performer {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public byte[] Waveform {get; set;}

	}
}
