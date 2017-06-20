namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xec22cfcd)]
    public class RequestSetBotUpdatesStatus : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int PendingUpdatesCount {get; set;}

       [SerializationOrder(1)]
       public string Message {get; set;}

    }
}
