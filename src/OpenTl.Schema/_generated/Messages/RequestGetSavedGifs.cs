// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x83bf3d52)]
    public sealed class RequestGetSavedGifs : IRequest<OpenTl.Schema.Messages.ISavedGifs>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
