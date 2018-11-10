// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x91d11eb)]
	public sealed class TFileLocation : IFileLocation
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       [SerializationOrder(1)]
       public long VolumeId {get; set;}

       [SerializationOrder(2)]
       public int LocalId {get; set;}

       [SerializationOrder(3)]
       public long Secret {get; set;}

       [SerializationOrder(4)]
       public byte[] FileReference {get; set;}

	}
}
