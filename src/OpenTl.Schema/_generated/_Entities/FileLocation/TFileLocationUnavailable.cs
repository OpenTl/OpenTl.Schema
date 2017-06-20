namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7c596b46)]
	public class TFileLocationUnavailable : IFileLocation
	{
       [SerializationOrder(0)]
       public long VolumeId {get; set;}

       [SerializationOrder(1)]
       public int LocalId {get; set;}

       [SerializationOrder(2)]
       public long Secret {get; set;}

	}
}
