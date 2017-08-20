// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBadMsgNotification : IObject
    {
       long BadMsgId {get; set;}

       int BadMsgSeqno {get; set;}

       int ErrorCode {get; set;}

    }
}
