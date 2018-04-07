// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7c596b46)]
	public sealed class TFileLocationUnavailable : IFileLocation
	{
       [SerializationOrder(0)]
       public long VolumeId {get; set;}

       [SerializationOrder(1)]
       public int LocalId {get; set;}

       [SerializationOrder(2)]
       public long Secret {get; set;}

	}
}
