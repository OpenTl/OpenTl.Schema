// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf05b4804)]
    public sealed class RequestInitTakeoutSession : IRequest<OpenTl.Schema.Account.ITakeout>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Contacts {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool MessageUsers {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool MessageChats {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool MessageMegagroups {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool MessageChannels {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool Files {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 5)]
       public int FileMaxSize {get; set;}

    }
}
