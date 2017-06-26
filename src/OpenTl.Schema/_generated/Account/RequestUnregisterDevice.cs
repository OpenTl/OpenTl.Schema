// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x65c55b40)]
    public class RequestUnregisterDevice : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int OkenType {get; set;}

       [SerializationOrder(1)]
       public string Token {get; set;}

    }
}
