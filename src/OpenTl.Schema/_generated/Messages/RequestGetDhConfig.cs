namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x26cf8950)]
    public class RequestGetDhConfig : IRequest<Messages.IDhConfig>
    {
       [SerializationOrder(0)]
       public int Version {get; set;}

       [SerializationOrder(1)]
       public int RandomLength {get; set;}

    }
}
