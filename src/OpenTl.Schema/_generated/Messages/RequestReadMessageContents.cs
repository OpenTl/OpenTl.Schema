// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x36a73f77)]
    public class RequestReadMessageContents : IRequest<Messages.IAffectedMessages>
    {
       [SerializationOrder(0)]
       public TVector<int> Id {get; set;}

    }
}
