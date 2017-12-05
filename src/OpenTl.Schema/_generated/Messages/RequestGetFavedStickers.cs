// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x21ce0b0e)]
    public class RequestGetFavedStickers : IRequest<OpenTl.Schema.Messages.IFavedStickers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
