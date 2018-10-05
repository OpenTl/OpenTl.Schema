// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdfdaabe1)]
	public sealed class TInputFileLocation : IInputFileLocation
	{
       [SerializationOrder(0)]
       public long VolumeId {get; set;}

       [SerializationOrder(1)]
       public int LocalId {get; set;}

       [SerializationOrder(2)]
       public long Secret {get; set;}

       [SerializationOrder(3)]
       public byte[] FileReference {get; set;}

	}
}
