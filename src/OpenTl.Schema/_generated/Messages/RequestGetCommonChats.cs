// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd0a48c4)]
    public sealed class RequestGetCommonChats : IRequest<OpenTl.Schema.Messages.IChats>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

       [SerializationOrder(2)]
       public int Limit {get; set;}

    }
}
