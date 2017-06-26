// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6f02f748)]
    public class RequestSaveAppLog : IRequest<bool>
    {
       [SerializationOrder(0)]
       public TVector<IInputAppEvent> Events {get; set;}

    }
}
