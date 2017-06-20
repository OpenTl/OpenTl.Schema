namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb55f4f18)]
	public class TInputMediaPhotoExternal : IInputMedia
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public string Caption {get; set;}

	}
}
