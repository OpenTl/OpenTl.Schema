// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageCommon : IObject
    {
       BitArray Flags {get; set;}

       bool Out {get; set;}

       bool Mentioned {get; set;}

       bool MediaUnread {get; set;}

       bool Silent {get; set;}

       bool Post {get; set;}

       int Id {get; set;}

       int FromId {get; set;}

       OpenTl.Schema.IPeer ToId {get; set;}

       int ReplyToMsgId {get; set;}

       int Date {get; set;}

    }
}
