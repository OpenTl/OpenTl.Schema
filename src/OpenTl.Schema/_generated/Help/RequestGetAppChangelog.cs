// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9010ef6f)]
    public class RequestGetAppChangelog : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public string PrevAppVersion {get; set;}

    }
}
