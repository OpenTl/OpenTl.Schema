// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPong : IObject
    {
       long MsgId {get; set;}

       long PingId {get; set;}

    }
}
