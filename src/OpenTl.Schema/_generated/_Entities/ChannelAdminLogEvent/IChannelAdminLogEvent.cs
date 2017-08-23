// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelAdminLogEvent : IObject
    {
       long Id {get; set;}

       int Date {get; set;}

       int UserId {get; set;}

       OpenTl.Schema.IChannelAdminLogEventAction Action {get; set;}

    }
}
