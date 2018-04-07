// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x36a73f77)]
    public sealed class RequestReadMessageContents : IRequest<OpenTl.Schema.Messages.IAffectedMessages>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

    }
}
