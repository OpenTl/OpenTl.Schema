// ReSharper disable All

namespace OpenTl.Schema.Updates
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IState : IObject
    {
       int Pts {get; set;}

       int Qts {get; set;}

       int Date {get; set;}

       int Seq {get; set;}

       int UnreadCount {get; set;}

    }
}
