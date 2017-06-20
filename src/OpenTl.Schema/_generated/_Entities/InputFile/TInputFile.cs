namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf52ff27f)]
	public class TInputFile : IInputFile
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public int Parts {get; set;}

       [SerializationOrder(2)]
       public string Name {get; set;}

       [SerializationOrder(3)]
       public string Md5Checksum {get; set;}

	}
}
